using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLKullanımıo
{
    class GraphQLQueries
    {
        public static string ALL_MOVIES = @"
            query {
              allMovies {
                id
                name
                year
                imdb
                subject
              }
            }";
        public static string ALL_DIRECTORS = @"
            query {
              allDirectors {
                id
                name
                birth
              }
            }";
        public static string MOVIE = @"
            query($id: ID!) {
              movie(id: $id) {
                id
                director {
                  id
                  name
                  birth
                }
              }
            }";
        public static string DIRECTOR = @"
            query($id: ID!) {
              director(id: $id) {
                id
                movies {
                  id
                  name
                  year
                  imdb
                  subject
                }
              }
            }";
        public static string ADD_DIRECTOR = @"
            mutation($name: String!, $birth: Int!) {
              addDirector(name: $name, birth: $birth) {
                id
              }
            }";
        public static string ADD_MOVIE = @"
            mutation(
              $name: String!
              $year: Int!
              $directorId: ID!
              $imdb: Int!
              $subject: String
            ) {
              addMovie(
                name: $name
                year: $year
                directorId: $directorId
                imdb: $imdb
                subject: $subject
              ) {
                id
              }
            }";
    }
}
