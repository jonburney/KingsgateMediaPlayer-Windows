﻿/*
 * Kingsgate Media Player
 * Copyright (C) 2016 Jon Burney (jon@version7.co.uk)
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 */
 using System.Collections.Generic;
using Models;

namespace DataProviders
{
    public class StaticData : IDataProvider
    {
        public List<VideoEntity> VideoList { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="videoCount"></param>
        public StaticData(int videoCount = 10)
        {
            VideoList = new List<VideoEntity>();

            for (var i = 0; i < videoCount; i++)
            {
                VideoList.Add(new VideoEntity()
                {
                    Title = "Video " + i,
                    Description = "Video Description " + i
                });
            }
        }

        /// <summary>
        /// Return a list of videos from the data source
        /// </summary>
        /// <returns>IEnumerable of VideoEntity objects</returns>
        public IEnumerable<VideoEntity> GetVideoList()
        {
            return VideoList;
        } 
    }
}
