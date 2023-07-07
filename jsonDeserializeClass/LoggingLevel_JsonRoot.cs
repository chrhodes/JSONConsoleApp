namespace JSONConsoleApp.jsonDeserializeClass
{
    public class LoggingLevel_JsonRoot
    {
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }

    }

    public class ColorX
    {
        public int A { get; set; }
        public int B { get; set; }
        public int G { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsKnownColor { get; set; }
        public bool IsNamedColor { get; set; }
        public bool IsSystemColor { get; set; }
        public string Name { get; set; }
        public int R { get; set; }
    }

    //public class LabelColorX
    //{
    //    public int A { get; set; }
    //    public int B { get; set; }
    //    public int G { get; set; }
    //    public bool IsEmpty { get; set; }
    //    public bool IsKnownColor { get; set; }
    //    public bool IsNamedColor { get; set; }
    //    public bool IsSystemColor { get; set; }
    //    public string Name { get; set; }
    //    public int R { get; set; }
    //}



}
