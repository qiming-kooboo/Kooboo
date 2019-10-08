﻿using Kooboo.Meta.Models;
using Kooboo.Meta.Views.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kooboo.Meta.Views
{
    public class KbDropdown : KbView
    {
        public class Item : KbClickable
        {
            public override string Name => nameof(Item);
            public string Text { get; set; }
        }

        public class Template : KbClickable
        {
            public override string Name => nameof(Template);
            public string TextPropery { get; set; }
        }

        public override string Name => nameof(KbDropdown);

        public string Text { get; set; }

        public List<Item> Items { get; private set; } = new List<Item>();

        public Template ItemTemplate { get; internal set; }
    }
}
