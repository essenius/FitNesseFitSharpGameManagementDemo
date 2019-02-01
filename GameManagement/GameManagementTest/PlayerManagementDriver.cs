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
using GameManagement;

namespace GameManagementTest
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global", Justification = "FitSharp can't find static classes"),
     SuppressMessage("ReSharper", "MemberCanBePrivate.Global", Justification = "Entry point for FitSharp"),
     SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Entry point for FitSharp")]
    public class PlayerManagementDriver
    {
        public static bool AddPlayerWithSkill(string playerName, string skillLevel)
        {
            var player = new Player(playerName, skillLevel);
            return StaticGame.Players.Add(player);
        }

        public static bool ClearPlayers()
        {
            StaticGame.Players.Clear();
            return PlayerCount() == 0;
        }

        public static int PlayerCount() => StaticGame.Players.Count;

        public static string PlayerIfSkill(string playerName)
        {
            var player = StaticGame.Players.FindOnName(playerName);
            return player == null ? "null" : player.Level;
        }

        public static bool RemovePlayer(string playerName)
        {
            var player = StaticGame.Players.FindOnName(playerName);
            if (player == null) return false;
            StaticGame.Players.Remove(player);
            return true;
        }

        public static bool UpdateSkillForPlayerTo(string playerName, string skillLevel)
        {
            var player = StaticGame.Players.FindOnName(playerName);
            if (player == null) return false;
            player.Level = skillLevel;
            return true;
        }
    }
}