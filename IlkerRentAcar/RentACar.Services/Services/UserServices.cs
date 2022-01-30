using RentACar.Data.Context;
using RentACar.Data.UnitOfWork;
using RentACar.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services.Services
{
    public interface IUserServices
    {
        List<UserDto> GetAll();
        UserDto GetById(int id);
        void Add(UserDto dto, UserTypeDto userTypeDto);
        void Update(UserDto dto);
        void Delete(int id);

        UserDto Login(string Username, string password);
    }
    public class UserServices : IUserServices
    {
        public void Add(UserDto dto, UserTypeDto userTypeDto)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = new User
                {
                    Id = dto.Id,
                    UsertypeId = userTypeDto.Id,
                    AdSoyad = dto.AdSoyad,
                    Parola = dto.Parola,
                    Email = dto.Email,
                    Adres = dto.Adres,
                    Telefon = dto.Telefon,
                };
                uow.GetRepository<User>().Add(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<User>().GetById(id);
                uow.GetRepository<User>().Delete(entity);
                uow.SaveChanges();
            }
        }

        public List<UserDto> GetAll()
        {

            List<UserDto> result = new List<UserDto>();
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var list = uow.GetRepository<User>().GetAll().ToList();
                result = list.Select(a => new UserDto
                {
                    Id = a.Id,
                    UsertypeId = a.UsertypeId,
                    AdSoyad = a.AdSoyad,
                    Parola = a.Parola,
                    Email = a.Email,
                    Adres = a.Adres,
                    Telefon = a.Telefon,
                }).ToList();
            }
            return result;
        }

        public UserDto GetById(int id)
        {
            UserDto result = new UserDto();
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<User>().GetById(id);
                result = new UserDto
                {
                    Id = entity.Id,
                    UsertypeId = entity.UsertypeId,
                    AdSoyad = entity.AdSoyad,
                    Parola = entity.Parola,
                    Email = entity.Email,
                    Adres = entity.Adres,
                    Telefon = entity.Telefon,
                };
            }
            return result;
        }

        public UserDto Login(string Username, string password)
        {
            UserDto result = new UserDto();
            
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<User>().GetAll(p => p.AdSoyad == Username && p.Parola == password).FirstOrDefault();

                if (entity == null)
                {
                    return null;
                }

                result = new UserDto
                {
                    Id = entity.Id,
                    UsertypeId = entity.UsertypeId,
                    AdSoyad = entity.AdSoyad,
                    Parola = entity.Parola,
                    Email = entity.Email,
                    Adres = entity.Adres,
                    Telefon = entity.Telefon,
                };
            }

            return result;
        }

        public void Update(UserDto dto)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<User>().GetById(dto.Id);

                entity.Id = dto.Id;
                entity.AdSoyad = dto.AdSoyad;
                entity.Parola = dto.Parola;
                entity.Email = dto.Email;
                entity.Adres = dto.Adres;
                entity.Telefon = dto.Telefon; 

                uow.GetRepository<User>().Update(entity);
                uow.SaveChanges();

            }
        }
    }
}
