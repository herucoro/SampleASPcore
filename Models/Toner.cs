namespace Sample.Models {
    public class Toner {
        public int id { get; set; }
        public int black { get; set; }
        public int magenta { get; set; }
        public int yellow { get; set; }
        public int cyan { get; set; }
        public int recovered_toner { get; set; }
        public int drum { get; set; }

        public List<Printer> Printers { get; set; }
    }
    public class Printer {
        public int id { get; set; }
        public string name { get; set; }
        public string floor { get; set; }
        public string now_record { get; set; }
        public DateTime checked_at { get; set; }

        public Toner toner { get; set; }
    }    
}