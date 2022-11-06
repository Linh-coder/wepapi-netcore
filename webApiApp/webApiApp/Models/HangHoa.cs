using System;

namespace webApiApp.Models
{
    public class HangHoaVM
    {
        public string Name { get; set; }
        
        public string Price { get; set; }
    }

    public class HangHoa : HangHoaVM
    {
        public Guid Code { get; set; }
    }
}
