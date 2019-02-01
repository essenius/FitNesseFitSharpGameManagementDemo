﻿// Copyright 2013-2019 Rik Essenius
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System.Collections.Generic;
using System.Linq;

namespace GameManagement
{
    public class PlayerCollection : HashSet<Player>
    {
        public Player FindOnName(string playerName) => (from Player p in this where p.Name == playerName select p).FirstOrDefault();

        public IEnumerable<Player> WithLevel(string level) => from Player p in this where p.Level == level select p;
    }
}