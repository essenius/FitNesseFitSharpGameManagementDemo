// Copyright 2013-2020 Rik Essenius
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

namespace GameManagementTest
{
    public class PlayersWithSkill
    {
        private readonly string _level;

        public PlayersWithSkill(string skillLevel) => _level = skillLevel;

        public List<object> Query() => StaticGame.Players.WithLevel(_level)
            .Select(p => new List<object> {new List<object> {"Player", p.Name}})
            .Cast<object>().ToList();
    }
}