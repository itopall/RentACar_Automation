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

    }
    public class MusteriServices : IMusteriServices
    {
        public List<MusteriDto> GetAll()
        {
            List<MusteriDto> result = new List<MusteriDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.GetRepository<Musteri>().GetAll().ToList();
                result = list.Select(m => new MusteriDto
                {
                    Id = m.Id,
                    Adi = m.Adi,
                    Soyad = m.Soyad,
                    Tc = m.Tc,
                    Cinsiyet = m.Cinsiyet,
                    Meslek = m.Meslek,
                    CepTel = m.CepTel,
                    IsTel = m.IsTel,
                    Email = m.Email,
                    Sehir = m.Sehir,
                    Adres = m.Adres,
                    EhliyetNo = m.EhliyetNo,
                    EhliyetTur = m.EhliyetTur,
                    EhliyetAlisTarih = m.EhliyetAlisTarih,
                    Notlar = m.Notlar
                }).ToList();
            }
            return result;
        }

        public MusteriDto GetById(int id)
        {
            MusteriDto result = new MusteriDto();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.GetRepository<Musteri>().GetById(id);
                result = new MusteriDto
                {
                    Id = entity.Id,
                    Adi = entity.Adi,
                    Soyad = entity.Soyad,
                    Tc = entity.Tc,
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
        public void Add(MusteriDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = new Musteri
                {
                    Id = dto.Id,
                    Adi = dto.Adi,
                    Soyad = dto.Soyad,
                    Tc = dto.Tc,
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
        public void Update(MusteriDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.GetRepository<Musteri>().GetById(dto.Id);
                entity.Id = dto.Id;
                entity.Adi = dto.Adi;
                entity.Soyad = dto.Soyad;
                entity.Tc = dto.Tc;
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
        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.GetRepository<Musteri>().GetById(id);
                uow.GetRepository<Musteri>().Remove(entity);
                uow.SaveChanges();
            }
        }
    }
}
