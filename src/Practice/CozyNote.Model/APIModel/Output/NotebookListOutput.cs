﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CozyNote.Model.ObjectModel;

namespace CozyNote.Model.APIModel.Output
{
    public class NotebookListOutput
    {
        public int ResultStatus { get; set; }

        public List<Note> NoteList { get; set; }
    }
}