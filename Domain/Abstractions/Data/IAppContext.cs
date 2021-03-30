﻿using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
 using Domain.Entities;
 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Domain.Abstractions.Data
{
    public interface IAppContext: IUnitOfWorkCreator
    {
        DbSet<User> Users { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<GroupSubject> GroupSubjects { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<TEntity> Set<TEntity>() where TEntity : class, IEntity;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        EntityEntry<TEntity> Entry<TEntity>([NotNull] TEntity entity)
            where TEntity : class, IEntity;
    }
}