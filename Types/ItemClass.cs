// MIT License
// 
// Copyright (c) 2018 reapler https://github.com/reapler
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
using System;
using DatabaseManager.Enums;


namespace DatabaseManager.Types
{
    /// <summary>
    /// Internal usage
    /// </summary>
    public class ItemClass
    {
        public int Type { get; }

        public int Id { get; }

        public ItemClass()
        {
            this.Type = -1;
            this.Id = -1;
        }
        
        public ItemClass(Consumable type)
        {
            this.Type = 0;
            this.Id = (int) type;
        }

        public ItemClass(Container type)
        {
            this.Type = 1;
            this.Id = (int) type;
        }

        public ItemClass(Weapon type)
        {
            this.Type = 2;
            this.Id = (int) type;
        }

        public ItemClass(Gem type)
        {
            this.Type = 3;
            this.Id = (int) type;
        }

        public ItemClass(Armor type)
        {
            this.Type = 4;
            this.Id = (int) type;
        }

        public ItemClass(Reagent type)
        {
            this.Type = 5;
            this.Id = (int) type;
        }

        public ItemClass(Projectile type)
        {
            this.Type = 6;
            this.Id = (int) type;
        }

        public ItemClass(TradeGoods type)
        {
            this.Type = 7;
            this.Id = (int) type;
        }

        public ItemClass(Recipe type)
        {
            this.Type = 9;
            this.Id = (int) type;
        }

        public ItemClass(Quiver type)
        {
            this.Type = 11;
            this.Id = (int) type;
        }

        public ItemClass(Quest type)
        {
            this.Type = 12;
            this.Id = (int) type;
        }

        public ItemClass(Key type)
        {
            this.Type = 13;
            this.Id = (int) type;
        }

        public ItemClass(Miscellaneous type)
        {
            this.Type = 15;
            this.Id = (int) type;
        }

        public ItemClass(Glyph type)
        {
            this.Type = 16;
            this.Id = (int) type;
        }
    }


    
}









