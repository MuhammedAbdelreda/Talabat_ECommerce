﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Talabat
{
    public interface ISpecification<T>
    {
        public Expression<Func<T,bool>> Criteria { get; set; } //could be null or not

        public List<Expression<Func<T,object>>> Includes { get; set; } //return all values with types

        public Expression<Func<T,object>> OrderBy { get; set; }

        public Expression<Func<T,object>> OrderByDescending {  get; set; }

        public int Take {  get; set; }

        public int Skip {  get; set; }

        public bool IsPaginationEnabled {  get; set; }

    }
}