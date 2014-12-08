﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintCoinach.Xiv {
    public class RecipeIngredient {
        #region Fields
        private RecipeIngredientType _Type;
        private Item _Item;
        private int _Count;
        #endregion

        #region Properties
        public RecipeIngredientType Type { get { return _Type; } }
        public Item Item { get { return _Item; } }
        public int Count { get { return _Count; } }
        #endregion

        #region Constructor
        public RecipeIngredient(RecipeIngredientType type, Item item, int count) {
            _Type = type;
            _Item = item;
            _Count = count;
        }
        #endregion
    }
}