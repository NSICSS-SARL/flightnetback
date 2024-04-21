﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Flight.Domain.Interfaces;
using Flight.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Flight.Infrastructure.Contracts;

/// <summary>
///     The generic repository.
/// </summary>
public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="GenericRepository" /> class.
    /// </summary>
    /// <param name="context">The context.</param>
    public GenericRepository(FlightContext context)
    {
        Context = context;
    }

    //The following variable is going to hold the FlightContext instance
    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    protected FlightContext Context { get; set; }

    /// <summary>
    ///     Adds the async.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <returns>A Task.</returns>
    public async Task<int> AddAsync(T entity)
    {
        try
        {
            await Context.Set<T>().AddAsync(entity);
            return await Save();
        }
        catch (Exception)
        {
            return 0;
        }
    }

    /// <summary>
    ///     Alls the async.
    /// </summary>
    /// <returns>A Task.</returns>
    public async Task<IEnumerable<T>> AllAsync()
    {
        return await Context.Set<T>().ToListAsync();
    }

    /// <summary>
    ///     Deletes the.
    /// </summary>
    /// <param name="entities">The entities.</param>
    public void Delete(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     Deletes the.
    /// </summary>
    /// <param name="predicate">The predicate.</param>
    public void Delete(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     Deletes the.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <returns>A Task.</returns>
    public async Task<int> Delete(T entity)
    {
        try
        {
            Context.Set<T>().Remove(entity);
            return await Save();
        }
        catch (Exception)
        {
            return 0;
        }
    }

    /// <summary>
    ///     Deletes the async.
    /// </summary>
    /// <param name="id">The id.</param>
    /// <returns>A Task.</returns>
    public async Task<int> DeleteAsync(int id)
    {
        var item = await Context.Set<T>().FindAsync(id);
        if (item is null) return 0;
        Context.Set<T>().Remove(item);
        return await Save();
    }

    /// <summary>
    ///     Gets the.
    /// </summary>
    /// <param name="expression">The expression.</param>
    /// <param name="trackChanges"></param>
    /// <returns>An IQueryable.</returns>
    public IQueryable<T> Get(Expression<Func<T, bool>> expression, bool trackChanges)
        =>
            !trackChanges
                ? Context.Set<T>()
                    .Where(expression)
                    .AsNoTracking()
                : Context.Set<T>()
                    .Where(expression);

    /// <summary>
    ///     Gets the by id async.
    /// </summary>
    /// <param name="id">The id.</param>
    /// <returns>A Task.</returns>
    public async Task<T> GetByIdAsync(int id)
    {
        return await Context.Set<T>().FindAsync(id);
    }

    /// <summary>
    ///     Inserts the.
    /// </summary>
    /// <param name="entities">The entities.</param>
    public void Insert(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     Saves the.
    /// </summary>
    /// <returns>A Task.</returns>
    public async Task<int> Save()
    {
        return await Context.SaveChangesAsync();
    }

    /// <summary>
    ///     Selects the.
    /// </summary>
    /// <param name="predicate">The predicate.</param>
    /// <returns>A T.</returns>
    public T Select(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     Selects the all by page.
    /// </summary>
    /// <param name="pageNumber">The page number.</param>
    /// <param name="quantity">The quantity.</param>
    /// <returns>A list of TS.</returns>
    public IList<T> SelectAllByPage(int pageNumber, int quantity)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     Selects the by key.
    /// </summary>
    /// <param name="primaryKeys">The primary keys.</param>
    /// <returns>A T.</returns>
    public T SelectByKey(params object[] primaryKeys)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     Updates the.
    /// </summary>
    /// <param name="entities">The entities.</param>
    public void Update(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     Updates the.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="properties">The properties.</param>
    public void Update(T entity, params Expression<Func<T, object>>[] properties)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     This method is going to update the record in the table
    ///     It will receive the object as an argument
    ///     <param name="entity">The entity.</param>
    ///     <returns>A Task.</returns>
    public async Task<int> Update(T entity)
    {
        try
        {
            Context.Set<T>().Update(entity);
            return await Save();
        }
        catch (Exception)
        {
            return 0;
        }
    }

    /// <summary>
    ///     Selects the all async.
    /// </summary>
    /// <returns>A Task.</returns>
    public async Task<IEnumerable<T>> SelectAllAsync()
    {
        IEnumerable<T> wfList = null;

        await Task.Run(() => { wfList = Context.Set<T>(); });

        return wfList;
    }

    /// <summary>
    /// Updates the async.
    /// </summary>
    /// <param name="old">The old.</param>
    /// <param name="entity">The entity.</param>
    /// <returns>A Task.</returns>
    public async Task<int> UpdateAsync(T old, T entity)
    {
        try
        {
            Context.Entry(old).CurrentValues.SetValues(entity);
            return await Context.SaveChangesAsync();
        }
        catch (Exception)
        {
            return 0;
        }
    }

    public IQueryable<T> FindAll(bool trackChanges) =>
        !trackChanges
            ? Context.Set<T>()
                .AsNoTracking()
            : Context.Set<T>();
}