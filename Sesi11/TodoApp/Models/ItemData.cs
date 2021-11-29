using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models{
    public class ItemData{
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool isDone { get; set; }
    }
}