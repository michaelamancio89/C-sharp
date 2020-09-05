using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderCodes
{
    public class Program
    {
        /// <summary>
        /// Identifiable expander types
        /// </summary>
        public enum Types
        {
            audio = 0,
            boolean = 1,
            background = 2,
            image = 3,
            effect = 4,
            strings = 5,
        }


        public class Expander
        {
            public bool IsExpanded { get; set; }
            public string CategoriesNames;

        }

        public class ExpanderProperties
        {
            /// <summary>
            /// 
            /// </summary>
            public class Item
            {
                public string ItemsNames;
            }


        }

        public class Effect
        {
            public string ColorEffects;
        }


    }
}
