using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> Get();
        Usuario Get(int id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);

    }
}
























































/*
        List<Usuario> Get();
        Usuario Get(int id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
*/