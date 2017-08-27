// MIT License
// 
// Copyright (c) 2017 reapler https://github.com/reapler
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
using System.Collections.Generic;
using System.Linq;
using DatabaseManager.Tables;
using wManager.Wow.Enums;


namespace DatabaseManager.WoW
{
    /// <summary>
    /// DbTransports
    /// <para>Returned positions are not complete</para>
    /// </summary>
    /// <para>Class to retrieve informations from database</para>
    public class DbTransport
    {
        /// <summary>
        /// Return data by filtering
        /// </summary>
        public static List<transports> Get()
        {
            using (var db = Access.Linq())
            {
                var transports = from t in db.transports
                    select t;
                var gameobject_template = from gt in db.gameobject_template
                    select new gameobject_template
                    {
                        entry = gt.entry,
                        name = gt.name,
                        Data0 = gt.Data0,
                    };
                var taxi_nodes = from tn in db.taxi_nodes
                    select tn;
                var taxi_path = from tp in db.taxi_path
                    select tp;
                transports = from t in transports
                    join gt in gameobject_template on t.entry equals gt.entry
                    join tp in taxi_path on gt.Data0 equals tp.ID
                    join from_tn in taxi_nodes on tp.FromTaxiNode equals from_tn.ID
                    join to_tn in taxi_nodes on tp.ToTaxiNode equals to_tn.ID
                    select new transports
                    {
                        entry = t.entry,
                        Name = gt.name,
                        From_X = from_tn.X,
                        From_Y = from_tn.Y,
                        From_Z = from_tn.Z,
                        From_ContinentId = (ContinentId)from_tn.ContinentID,
                        To_X = to_tn.X,
                        To_Y = to_tn.Y,
                        To_Z = to_tn.Z,
                        To_ContinentId = (ContinentId)to_tn.ContinentID,
                    };
                return transports.ToList();
            }
        }
    }
}







