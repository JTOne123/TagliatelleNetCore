﻿namespace Cimpress.TagliatelleNetCore
{
    public interface IClient
    {
        IClientRequest<T> Tag<T>();
    }
}