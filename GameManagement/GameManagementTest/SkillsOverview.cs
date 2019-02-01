// Copyright 2013-2019 Rik Essenius
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System.Diagnostics.CodeAnalysis;
using static GameManagementTest.PlayerManagementDriver;

namespace GameManagementTest
{
    [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Entry point for FitSharp")]
    public class SkillsOverview
    {
        private string _player;

        public object Get(string requestedSkill) =>
            PlayerIfSkill(_player) == requestedSkill ? "X" : string.Empty;

        public void Set(string name, string value) => _player = value;
    }
}