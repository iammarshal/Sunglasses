using Sunglasses_Repository;
using Sunglasses_Repository.CustomModels;
using Sunglasses_Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_PRN211_FA23_1237778_NguyenQuocThien
{
    public partial class SunglassForm : Form
    {
        SunglassRepo sunglassRepo;
        ManufacturerRepo manufacturerRepo;
        public SunglassForm()
        {
            InitializeComponent();
            sunglassRepo = new SunglassRepo();
            manufacturerRepo = new ManufacturerRepo();
            LoadData();

        }
        public void LoadData()
        {
            var getProduct = sunglassRepo.GetAll().ToList();
            List<SunglassModel> SunglassProduct = new();
            foreach (var item in getProduct)
            {
                var getmanufacturer = manufacturerRepo.GetAll().Where(x => x.ManufacturerId.Equals(item.ManufacturerId)).FirstOrDefault();
                SunglassProduct.Add(new SunglassModel()
                {
                    SunglassesId = item.SunglassesId,
                    SunglassesName = item.SunglassesName,
                    Feature = item.Feature,
                    Material = item.Material,
                    Shape = item.Shape,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    CreatedDate = item.CreatedDate,
                    ManufacturerId = item.ManufacturerId,
                    ManufacturerName = getmanufacturer.ManufacturerName
                });
            }
            BindingSource source = new BindingSource();
            source.DataSource = SunglassProduct;
            DGV_Sunglasses.DataSource = source;
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            var searchvalue = txtSearch.Text;
            var matchList = _sunglassRepository.GetAll().Where(s => s.Material.Contains(searchvalue) ||
                                                                    s.Feature.Contains(searchvalue))
                    .Include(s => s.Manufacturer)
                .Select(s => new
                {
                    s.SunglassesId,
                    s.SunglassesName,
                    s.Feature,
                    s.Material,
                    s.Shape,
                    s.Price,
                    s.Quantity,
                    s.CreatedDate,
                    s.Manufacturer.ManufacturerName
                }).ToList();
            dgvSunglass.DataSource = matchList;
        }
    }
}
