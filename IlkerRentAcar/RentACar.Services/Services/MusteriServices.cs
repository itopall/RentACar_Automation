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

    public interface IMusteriServices
    {
        List<MusteriDto> GetAll();
        MusteriDto GetById(int id);
        void Add(MusteriDto dto);
        void Update(MusteriDto dto);
        void Delete(int id);
        List<MusteriDto> GetByName(string name);
    }
    public class MusteriServices : IMusteriServices
    {
        public void Add(MusteriDto dto)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = new Musteri
                {
                    Id = dto.Id,
                    Adi = dto.Adi,
                    Soyad = dto.Soyad,
                    Tc = dto.Tc,
                    DogumTarihi = dto.DogumTarihi,
                    Cinsiyet = dto.Cinsiyet,
                    Meslek = dto.Meslek,
                    CepTel = dto.CepTel,
                    IsTel = dto.IsTel,
                    Email = dto.Email,
                    Sehir = dto.Sehir,
                    Adres = dto.Adres,
                    EhliyetNo = dto.EhliyetNo,
                    EhliyetTur = dto.EhliyetTur,
                    EhliyetAlisTarih = dto.EhliyetAlisTarih,
                    Notlar = dto.Notlar
                };
                uow.GetRepository<Musteri>().Add(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<Musteri>().GetById(id);
                uow.GetRepository<Musteri>().Delete(entity);
                uow.SaveChanges();
            }
        }

        public List<MusteriDto> GetAll()
        {
            List<MusteriDto> result = new List<MusteriDto>();
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var list = uow.GetRepository<Musteri>().GetAll().ToList();

                result = list.Select(p => new MusteriDto
                {
                    Id = p.Id,
                    Adi = p.Adi,
                    Soyad = p.Soyad,
                    Tc = p.Tc,
                    DogumTarihi = p.DogumTarihi,
                    Cinsiyet = p.Cinsiyet,
                    Meslek = p.Meslek,
                    CepTel = p.CepTel,
                    IsTel = p.IsTel,
                    Email = p.Email,
                    Sehir = p.Sehir,
                    Adres = p.Adres,
                    EhliyetNo = p.EhliyetNo,
                    EhliyetTur = p.EhliyetTur,
                    EhliyetAlisTarih = p.EhliyetAlisTarih,
                    Notlar = p.Notlar
                }).ToList();
               
            }
            return result;
        }

        public MusteriDto GetById(int id)
        {
            MusteriDto result = new MusteriDto();
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<Musteri>().GetById(id);
                result = new MusteriDto
                {
                    Id = entity.Id,
                    Adi = entity.Adi,
                    Soyad = entity.Soyad,
                    Tc = entity.Tc,
                    DogumTarihi = entity.DogumTarihi,
                    Cinsiyet = entity.Cinsiyet,
                    Meslek = entity.Meslek,
                    CepTel = entity.CepTel,
                    IsTel = entity.IsTel,
                    Email = entity.Email,
                    Sehir = entity.Sehir,
                    Adres = entity.Adres,
                    EhliyetNo = entity.EhliyetNo,
                    EhliyetTur = entity.EhliyetTur,
                    EhliyetAlisTarih = entity.EhliyetAlisTarih,
                    Notlar = entity.Notlar
                };
            }
            return result;
        }

        public void Update(MusteriDto dto)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<Musteri>().GetById(dto.Id);
                entity.Id = dto.Id;
                entity.Adi = dto.Adi;
                entity.Soyad = dto.Soyad;
                entity.Tc = dto.Tc;
                entity.DogumTarihi = dto.DogumTarihi;
                entity.Cinsiyet = dto.Cinsiyet;
                entity.Meslek = dto.Meslek;
                entity.CepTel = dto.CepTel;
                entity.IsTel = dto.IsTel;
                entity.Email = dto.Email;
                entity.Sehir = dto.Sehir;
                entity.Adres = dto.Adres;
                entity.EhliyetNo = dto.EhliyetNo;
                entity.EhliyetTur = dto.EhliyetTur;
                entity.EhliyetAlisTarih = dto.EhliyetAlisTarih;
                entity.Notlar = dto.Notlar;

                uow.GetRepository<Musteri>().Update(entity);
                uow.SaveChanges();

            }
        }

        public List<MusteriDto> GetByName(string name)
        {
            List<MusteriDto> result = new List<MusteriDto>();
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var list = uow.GetRepository<Musteri>().GetAll(p => p.Adi.ToUpper().Contains(name.ToUpper()) || p.Tc.ToUpper().Contains(name.ToUpper()) || p.Email.ToUpper().Contains(name.ToUpper())).ToList();

                result = list.Select(p => new MusteriDto
                {
                    Id = p.Id,
                    Adi = p.Adi,
                    Soyad = p.Soyad,
                    Tc = p.Tc,
                    DogumTarihi = p.DogumTarihi,
                    Cinsiyet = p.Cinsiyet,
                    Meslek = p.Meslek,
                    CepTel = p.CepTel,
                    IsTel = p.IsTel,
                    Email = p.Email,
                    Sehir = p.Sehir,
                    Adres = p.Adres,
                    EhliyetNo = p.EhliyetNo,
                    EhliyetTur = p.EhliyetTur,
                    EhliyetAlisTarih = p.EhliyetAlisTarih,
                    Notlar = p.Notlar
                }).ToList();

            }
            return result;
        }
    }
}
