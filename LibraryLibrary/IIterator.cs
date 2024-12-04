﻿namespace LibraryLibrary
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
