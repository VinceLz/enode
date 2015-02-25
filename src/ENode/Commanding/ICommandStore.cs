﻿using System.Threading.Tasks;
using ENode.Infrastructure;

namespace ENode.Commanding
{
    /// <summary>Represents a command store to store all the handled commands.
    /// </summary>
    public interface ICommandStore
    {
        /// <summary>Add the given handled command to the command store.
        /// </summary>
        CommandAddResult Add(HandledCommand handledCommand);
        /// <summary>Add the given handled command to the command store async.
        /// </summary>
        Task<AsyncOperationResult<CommandAddResult>> AddAsync(HandledCommand handledCommand);
        /// <summary>Remove a handled command by commandId.
        /// </summary>
        /// <returns></returns>
        void Remove(string commandId);
        /// <summary>Remove a handled command by commandId async.
        /// </summary>
        Task<AsyncOperationResult> RemoveAsync(string commandId);
        /// <summary>Get a handled command by commandId.
        /// </summary>
        /// <returns></returns>
        HandledCommand Get(string commandId);
        /// <summary>Get a handled command by commandId async.
        /// </summary>
        Task<AsyncOperationResult<HandledCommand>> GetAsync(string commandId);
    }
}
