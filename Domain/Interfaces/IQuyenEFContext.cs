using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IQuyenEFContext
    {
        List<Quyen> Quyen_GetAll();
        Quyen Quyen_GetById(int id);
        void Quyen_Add(Quyen Q);
        void Quyen_Update(Quyen Q);
        void Quyen_Remove(Quyen Q);
    }
}