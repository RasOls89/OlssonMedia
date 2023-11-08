using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Internals;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataLayer
{
    public class UnitofWork : IUnitofWork
    {
        private MediaDBContext _mediaDBContext = new MediaDBContext();

        public Repository<User> UserRepository { get; private set; }
        public Repository<Actor> ActorRepository { get; private set; }
        public Repository<Album> AlbumRepository { get; private set; }
        public Repository<Band> BandRepository { get; private set; }
        public Repository<Book> BookRepository { get; private set; }
        public Repository<Movie> MovieRepository { get; private set; }
        public UnitofWork()
        {
            UserRepository = new Repository<User>(_mediaDBContext);
            ActorRepository = new Repository<Actor>(_mediaDBContext);
            AlbumRepository = new Repository<Album>(_mediaDBContext);
            BandRepository = new Repository<Band>(_mediaDBContext);
            BookRepository = new Repository<Book>(_mediaDBContext);
            MovieRepository = new Repository<Movie>(_mediaDBContext);
        }

        public void Complete()
        {
            _mediaDBContext.SaveChanges();
        }
        public void Dispose()
        {
            _mediaDBContext.Dispose();
        }
    }
}
