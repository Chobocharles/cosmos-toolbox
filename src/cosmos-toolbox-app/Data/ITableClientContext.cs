﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using CosmosToolbox.Core.Data;
using Microsoft.Azure.Cosmos.Table;

namespace CosmosToolbox.App.Data
{
    public interface ITableClientContext : IClientContext
    {
        Task<IEnumerable<TEntity>> ReadItemsAsync<TEntity>(
            Expression<Func<TEntity, bool>> predicate, string partitionKey,
            CancellationToken cancellationToken)
            where TEntity : class, ITableEntity, new();
    }
}