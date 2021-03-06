﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.Services.Dtos
{
    public class QuestionDto
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Notes { get; set; }

        public int Type { get; set; }

        public int Flags { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}
