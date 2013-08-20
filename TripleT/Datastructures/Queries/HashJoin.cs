﻿/* TripleT: an RDF database engine.
 * Copyright (C) 2012-2013 Eindhoven University of Technology <http://www.tue.nl/>
 * Copyright (C) 2012-2013 Bart Wolff <http://www.bartwolff.com/>
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
 **/

namespace TripleT.Datastructures.Queries
{
    /// <summary>
    /// Represents a hash join operator in a descriptive query plan. This operator does not perform
    /// any physical operations.
    /// </summary>
    public class HashJoin : Operator
    {
        private readonly Operator m_left;
        private readonly Operator m_right;

        /// <summary>
        /// Initializes a new instance of the <see cref="HashJoin"/> class.
        /// </summary>
        /// <param name="left">The left input operator.</param>
        /// <param name="right">The right input operator.</param>
        public HashJoin(Operator left, Operator right)
        {
            m_left = left;
            m_right = right;
        }

        /// <summary>
        /// Gets the left input operator.
        /// </summary>
        public Operator Left
        {
            get { return m_left; }
        }

        /// <summary>
        /// Gets the right input operator.
        /// </summary>
        public Operator Right
        {
            get { return m_right; }
        }
    }
}
