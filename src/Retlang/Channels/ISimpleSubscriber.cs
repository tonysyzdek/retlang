using System;
using Retlang.Fibers;

namespace Retlang.Channels
{
    /// <summary>
    /// Channel subscription methods.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISimpleSubscriber<out T>
    {
        ///<summary>
        /// Subscribe to messages on this channel. The provided action will be invoked via a Action on the provided executor.
        ///</summary>
        ///<param name="fiber">the target executor to receive the message</param>
        ///<param name="receive"></param>
        ///<returns>Unsubscriber object</returns>
        IDisposable Subscribe(IFiber fiber, Action<T> receive);
    }
}