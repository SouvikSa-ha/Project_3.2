using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevCom.Models
{
    public class NotepadViewModel
    {
        public IEnumerable<Notepad> Notepads { get; set; }
        public IEnumerable<Text> Texts { get; set; }
        public Notepad Notepad { get; set; }
        public Text Text { get; set; }
    }
}