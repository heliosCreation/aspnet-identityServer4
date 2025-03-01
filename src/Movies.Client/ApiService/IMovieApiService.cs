﻿using Movies.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.ApiService
{
    public interface IMovieApiService
    {
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovie(Guid? id);
        Task CreateMovie(Movie movie);
        Task UpdateMovie(Movie movie);
        Task DeleteMovie(Guid id);

        Task<UserInfoViewModel> GetUserInfo();
    }
}
