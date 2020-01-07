/*************************************************************
** File: Student.cs
** Author/s: Justin Rough
** Description:
**     This file contains the student class that is written
** to/read from a binary file.  The FromStream() and
** ToStream() methods provide for the conversion of binary
** data to a Student object and vice versa, respectively.
*************************************************************/
using System;
using System.IO;
using System.Text;

namespace RandomAccessFiles
{
    [Serializable]
    class Student
    {
        public const int MAX_NAME_LENGTH = 10;

        public static void FromStream(Stream stream, out Student student)
        {
            object[] objArray = new object[3];
            objArray[0] = 3;
            objArray[1] = '3';
            objArray[2] = "three"; 
            BinaryReader br = new BinaryReader(stream, Encoding.Unicode);
            student = new Student();

            // Read the _ID
            student._ID = br.ReadInt32();

            // Read the length of _Name
            int length = br.ReadInt32();

            // Read the _Name
            char[] name = br.ReadChars(MAX_NAME_LENGTH);
            if (length != MAX_NAME_LENGTH)
            {
                char[] tmp = new char[length];
                for (int i = 0; i < length; i++)
                    tmp[i] = name[i];
                name = tmp;
            }
            student._Name = new string(name);

            // Read the _BirthYear
            student._BirthYear = br.ReadUInt16();

            // Read the _BirthMonth
            student._BirthMonth = br.ReadByte();

            // Read the _BirthDay
            student._BirthDay = br.ReadByte();
        }
        
        public static void ToStream(Stream stream, Student student)
        {
            BinaryWriter bw = new BinaryWriter(stream, Encoding.Unicode);

            bw.Write(student._ID);              // Write out _ID

            // Write out the length of _Name
            int nameLength = student._Name.Length;
            if (nameLength > MAX_NAME_LENGTH)
                nameLength = MAX_NAME_LENGTH;
            bw.Write(nameLength);

            // Prepare to write out _Name
            char[] name = student._Name.ToCharArray();
            int length = Math.Min(student._Name.Length, MAX_NAME_LENGTH);
            if(name.Length != MAX_NAME_LENGTH)
            {
                char [] tmp = new char[MAX_NAME_LENGTH];
                int i = 0;
                while(i < length)
                {
                    tmp[i] = name[i];
                    i++;
                }
                while(i < MAX_NAME_LENGTH)
                {
                    tmp[i++] = '\0';
                }
                name = tmp;
            }
            bw.Write(name, 0, name.Length);     // Write out _Name

            bw.Write(student._BirthYear);       // Write out _BirthYear
            bw.Write(student._BirthMonth);      // Write out _BirthMonth
            bw.Write(student._BirthDay);        // Write out _BirthDay
        }

        public static int RecordLength
        {
            get
            {
                int length = 0;

                length += sizeof(int); // _ID
                length += sizeof(int); // Length of _Name
                length += sizeof(char) * MAX_NAME_LENGTH; // _Name
                length += sizeof(ushort); // _BirthYear
                length += sizeof(byte); // _BirthMonth
                length += sizeof(byte); // _BirthDay

                return length;
            }
        }

        private Student()
        {
        }

        public Student(int id, string name, ushort birthYear, byte birthMonth, byte birthDay)
        {
            _ID = id;
            _Name = name;
            _BirthYear = birthYear;
            _BirthMonth = birthMonth;
            _BirthDay = birthDay;
        }

        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private ushort _BirthYear;
        public ushort BirthYear
        {
            get { return _BirthYear; }
            set { _BirthYear = value; }
        }

        private byte _BirthMonth;
        public byte BirthMonth
        {
            get { return _BirthMonth; }
            set { _BirthMonth = value; }
        }

        private byte _BirthDay;
        public byte BirthDay
        {
            get { return _BirthDay; }
            set { _BirthDay = value; }
        }

        public override string ToString()
        {
            return string.Format("ID {0} (Born {1}/{2}/{3}) - {4}", _ID, _BirthDay, _BirthMonth, _BirthYear, _Name);
        }
    }
}
