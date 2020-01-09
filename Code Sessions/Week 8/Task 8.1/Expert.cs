namespace Task_8._1
{
    public class Expert
    {
        public Expert(string techField, string pubField, string project)
        {
            _TechField = techField;
            _PubField = pubField;
            _Project = project;
        }

        private string _TechField;
        public string TechField
        {
            get => _TechField;
            set => _TechField = value;
        }

        private string _PubField;
        public string PubField
        {
            get => _PubField;
            set => _PubField = value;
        }

        private string _Project;
        public string Project
        {
            get => _Project;
            set => _Project = value;
        }

        public override string ToString() => $"{_TechField}, {_PubField}";
    
    }
}