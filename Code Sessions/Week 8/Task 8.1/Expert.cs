namespace Task_8._1
{
    public class Expert
    {
        public Expert(string field, string project)
        {
            _Field = field;
            _Project = project;
        }

        private string _Field;
        public string Field
        {
            get => _Field;
            set => _Field = value;
        }

        private string _Project;
        public string Project
        {
            get => _Project;
            set => _Project = value;
        }
    }
}