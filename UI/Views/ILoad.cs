﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Views
{
    public interface ILoad
    {
        event EventHandler Loaded;

        void Reload();
    }
}
