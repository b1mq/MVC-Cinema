using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> films { get; set; } = null!;
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {
           
           
            if (Database.EnsureCreated())
            {
                // заполнил с  помощью ИИ
                films?.Add(new Film
                {
                    Title = "Побег из Шоушенка",
                    Description = "Успешный банкир Энди Дюфрейн обвинен в убийстве жены и ее любовника. Попадая в мрачную тюрьму Шоушенк, он сталкивается с жестокостью и беззаконием, но не теряет надежду.",
                    Release_Year = 1994,
                    Director = "Фрэнк Дарабонт",
                    Language = "Английский",
                    Country = "США",
                    Genre = "Драма",
                    Poster_Url = "https://m.media-amazon.com/images/M/MV5BMDAyY2FhYjctNDc5OS00MDNlLThiMGUtY2UxYWVkNGY2ZjljXkEyXkFqcGc@._V1_QL75_UX380_CR0,4,380,562_.jpg",
                    Rating = 9.3m
                });

                films?.Add(new Film
                {
                    Title = "Крестный отец",
                    Description = "Криминальная эпическая драма о сицилийской мафиозной семье Корлеоне в Нью-Йорке. История о власти, семье и цене, которую приходится за них платить.",
                    Release_Year = 1972,
                    Director = "Фрэнсис Форд Коппола",
                    Language = "Английский",
                    Country = "США",
                    Genre = "Криминал, Драма",
                    Poster_Url = "https://m.media-amazon.com/images/M/MV5BNGEwYjgwOGQtYjg5ZS00Njc1LTk2ZGEtM2QwZWQ2NjdhZTE5XkEyXkFqcGc@._V1_QL75_UY562_CR8,0,380,562_.jpg",
                    Rating = 9.2m
                });

                films?.Add(new Film
                {
                    Title = "Темный рыцарь",
                    Description = "Бэтмен поднимает ставки в войне с криминалом. С помощью лейтенанта Джима Гордона и прокурора Харви Дента он намерен очистить улицы Готэма от преступности, но сталкивается с гением хаоса — Джокером.",
                    Release_Year = 2008,
                    Director = "Кристофер Нолан",
                    Language = "Английский",
                    Country = "США, Великобритания",
                    Genre = "Фантастика, Боевик, Криминал",
                    Poster_Url = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_QL75_UX380_CR0,0,380,562_.jpg",
                    Rating = 9.0m
                });

                films?.Add(new Film
                {
                    Title = "Список Шиндлера",
                    Description = "Реальная история немецкого бизнесмена Оскара Шиндлера, спасшего более тысячи польских евреев от гибели во время Холокоста.",
                    Release_Year = 1993,
                    Director = "Стивен Спилберг",
                    Language = "Английский, Немецкий",
                    Country = "США",
                    Genre = "Биография, Драма, История",
                    Poster_Url = "https://m.media-amazon.com/images/M/MV5BNjM1ZDQxYWUtMzQyZS00MTE1LWJmZGYtNGUyNTdlYjM3ZmVmXkEyXkFqcGc@._V1_QL75_UX380_CR0,4,380,562_.jpg",
                    Rating = 9.0m
                });

                films?.Add(new Film
                {
                    Title = "Криминальное чтиво",
                    Description = "Нелинейная история о двух философствующих бандитах, боксере, жене мафиози и паре грабителей, чьи судьбы переплетаются в серии забавных и опасных инцидентов.",
                    Release_Year = 1994,
                    Director = "Квентин Тарантино",
                    Language = "Английский",
                    Country = "США",
                    Genre = "Криминал, Комедия",
                    Poster_Url = "https://m.media-amazon.com/images/M/MV5BYTViYTE3ZGQtNDBlMC00ZTAyLTkyODMtZGRiZDg0MjA2YThkXkEyXkFqcGc@._V1_QL75_UY562_CR3,0,380,562_.jpg",
                    Rating = 8.9m
                });

                films?.Add(new Film
                {
                    Title = "Властелин колец: Возвращение короля",
                    Description = "Повелитель сил Тьмы Саурон направляет свои бесчисленные войска к стенам Минас-Тирита. Фродо и Сэм продолжают путь к Роковой Горе, чтобы уничтожить Кольцо Всевластья.",
                    Release_Year = 2003,
                    Director = "Питер Джексон",
                    Language = "Английский",
                    Country = "Новая Зеландия, США",
                    Genre = "Фэнтези, Приключения",
                    Poster_Url = "https://m.media-amazon.com/images/M/MV5BMTZkMjBjNWMtZGI5OC00MGU0LTk4ZTItODg2NWM3NTVmNWQ4XkEyXkFqcGc@._V1_QL75_UX380_CR0,0,380,562_.jpg",
                    Rating = 9.0m
                });

                films?.Add(new Film
                {
                    Title = "Бойцовский клуб",
                    Description = "Сотрудник страховой компании, страдающий бессонницей, знакомится с харизматичным продавцом мыла Тайлером Дерденом. Вместе они организуют подпольный бойцовский клуб.",
                    Release_Year = 1999,
                    Director = "Дэвид Финчер",
                    Language = "Английский",
                    Country = "США, Германия",
                    Genre = "Триллер, Драма",
                    Poster_Url = "https://m.media-amazon.com/images/M/MV5BOTgyOGQ1NDItNGU3Ny00MjU3LTg2YWEtNmEyYjBiMjI1Y2M5XkEyXkFqcGc@._V1_QL75_UX380_CR0,4,380,562_.jpg",
                    Rating = 8.8m
                });

                films?.Add(new Film
                {
                    Title = "Форрест Гамп",
                    Description = "История слабоумного, но доброго и открытого человека, который невольно становится участником важнейших событий истории США XX века.",
                    Release_Year = 1994,
                    Director = "Роберт Земекис",
                    Language = "Английский",
                    Country = "США",
                    Genre = "Драма, Комедия",
                    Poster_Url = "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_QL75_UY562_CR4,0,380,562_.jpg",
                    Rating = 8.8m
                });

                films?.Add(new Film
                {
                    Title = "Начало",
                    Description = "Кобб — профессиональный вор, который крадет ценные секреты из глубин подсознания во время сна. Ему предлагают последнее дело: не украсть мысль, а внедрить ее.",
                    Release_Year = 2010,
                    Director = "Кристофер Нолан",
                    Language = "Английский",
                    Country = "США, Великобритания",
                    Genre = "Фантастика, Боевик, Детектив",
                    Poster_Url = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_QL75_UX380_CR0,0,380,562_.jpg",
                    Rating = 8.8m
                });

                films?.Add(new Film
                {
                    Title = "Матрица",
                    Description = "Программист Нео узнает, что привычная реальность — это иллюзия, созданная разумными машинами для контроля над человечеством.",
                    Release_Year = 1999,
                    Director = "Лана Вачовски, Лилли Вачовски",
                    Language = "Английский",
                    Country = "США, Австралия",
                    Genre = "Фантастика, Боевик",
                    Poster_Url = "https://m.media-amazon.com/images/M/MV5BN2NmN2VhMTQtMDNiOS00NDlhLTliMjgtODE2ZTY0ODQyNDRhXkEyXkFqcGc@._V1_QL75_UX380_CR0,4,380,562_.jpg",
                    Rating = 8.7m
                });
                SaveChanges();
            }
        }
    }
}
