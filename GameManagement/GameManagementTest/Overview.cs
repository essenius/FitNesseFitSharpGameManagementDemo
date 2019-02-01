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
using System.Diagnostics.CodeAnalysis;

namespace GameManagementTest
{
    using RowList = List<string>;
    using TableList = List<List<string>>;

    [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "FitNesse interface spec"),
     SuppressMessage("ReSharper", "UnusedParameter.Global", Justification = "FitNesse interface spec")]
    public class Overview
    {
        public TableList DoTable(TableList table) => new TableList
        {
            new RowList {"report:Number of players", "pass:" + StaticGame.Players.Count}
        };
    }
}