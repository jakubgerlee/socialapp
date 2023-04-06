﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Social.Dal.Configurations;
using Social.Domain.Aggregates.PostAggregate;
using Social.Domain.Aggregates.UserProfileAggregate;

namespace Social.Dal;

public class DataContext : IdentityDbContext 
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    private DbSet<UserProfile> UserProfiles { get; set; }
    private DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new PostCommentConfig()); 
        builder.ApplyConfiguration(new PostInteractionConfig()); 
        builder.ApplyConfiguration(new UserProfileConfig()); 
        builder.ApplyConfiguration(new IdentityUserLoginConfig()); 
        builder.ApplyConfiguration(new IdentityUserRoleConfig()); 
        builder.ApplyConfiguration(new IdentityUserTokenConfig()); 
    }
}