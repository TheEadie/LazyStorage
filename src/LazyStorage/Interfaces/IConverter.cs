﻿namespace LazyStorage.Interfaces
{
    public interface IConverter<T>
    {
        StorableObject GetStorableObject(T item);
        T GetOriginalObject(StorableObject info);
        bool IsEqual(StorableObject storageObject, T realObject);
    }
}