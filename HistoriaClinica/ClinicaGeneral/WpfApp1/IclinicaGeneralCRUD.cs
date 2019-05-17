using System;
using System.Collections.Generic;
namespace WpfApp1
{
    /// <summary>
    /// clase que define las operaciones basica sobre la base de datos(CRUD)
    /// </summary>
    public interface IclinicaGeneralCRUD<T>
    {
        void Insetar(T entidade);
        void Acutalizar(T entidade);
        void Excluir(T entidade);
        T RetornarPorId(int Id);
        IList<T> Consultar();
    }
}
