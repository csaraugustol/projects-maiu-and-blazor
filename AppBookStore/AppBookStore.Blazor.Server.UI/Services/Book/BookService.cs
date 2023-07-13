﻿using AppBookStore.Blazor.Server.UI.Services.Base;
using AppBookStore.Blazor.Server.UI.Services.Book;
using AutoMapper;
using Blazored.LocalStorage;
using System;

namespace AppBookStore.Blazor.Server.UI.Services.Book
{
    public class BookService : BaseHttpService, IBookService
    {
        private readonly IClient client;
        private readonly IMapper mapper;

        public BookService(IClient client, ILocalStorageService localStorage, IMapper mapper) : base(client, localStorage)
        {
            this.client = client;
            this.mapper = mapper;
        }

        public async Task<Response<int>> Create(BookCreateDto bookDto)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.BooksPOSTAsync(bookDto);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<int>> Delete(int id)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.BooksDELETEAsync(id);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<int>> Edit(int id, BookUpdateDto bookDto)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.BooksPUTAsync(id, bookDto);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<BookDetailsDto>> GetBook(int id)
        {
            Response<BookDetailsDto> response;

            try
            {
                await GetBearerToken();
                var data = await client.BooksGETAsync(id);
                response = new Response<BookDetailsDto>
                {
                    Data = data,
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<BookDetailsDto>(exception);
            }

            return response;
        }

        public async Task<Response<BookUpdateDto>> GetBookForUpdate(int id)
        {
            Response<BookUpdateDto> response;

            try
            {
                await GetBearerToken();
                var data = await client.BooksGETAsync(id);
                response = new Response<BookUpdateDto>
                {
                    Data = mapper.Map<BookUpdateDto>(data),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<BookUpdateDto>(exception);
            }

            return response;
        }

        public async Task<Response<List<BookReadOnlyDto>>> GetBooks()
        {
            Response<List<BookReadOnlyDto>> response;

            try
            {
                await GetBearerToken();
                var data = await client.BooksAllAsync();
                response = new Response<List<BookReadOnlyDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<List<BookReadOnlyDto>>(exception);
            }

            return response;
        }
    }
}
