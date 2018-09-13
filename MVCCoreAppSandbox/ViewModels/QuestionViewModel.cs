using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreAppSandbox.ViewModels
{
    public class QuestionViewModel
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Notes { get; set; }

        public int Type { get; set; }

        public int Flags { get; set; }
    }
}
