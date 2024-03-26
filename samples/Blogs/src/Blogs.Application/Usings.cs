global using System.Diagnostics.CodeAnalysis;
global using Blogs.Core.Domain.AggregatesModel.BlogAggregate;
global using Blogs.Core.Domain.AggregatesModel.PersonAggregate;
global using Blogs.Core.Domain.AggregatesModel.PostAggregate;
global using Blogs.Core.ReadModel;
global using BuildingBlocks.Exceptions;
global using BuildingBlocks.Persistence.Abstractions;
global using MediatR;
global using Microsoft.AspNetCore.JsonPatch;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;