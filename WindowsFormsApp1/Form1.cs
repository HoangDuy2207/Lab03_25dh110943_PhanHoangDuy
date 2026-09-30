using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblHostNameValue_Click(object sender, EventArgs e)
        {

        }

        private void btnGetlnfo_Click(object sender, EventArgs e)
        {
            // ==========================================
            // 1. LẤY TÊN HOST VÀ ĐỊA CHỈ IP CHÍNH
            // ==========================================
            try
            {
                // Lấy Tên Host
                string hostName = Dns.GetHostName();
                lblHostNameValue.Text = hostName;

                // Lấy IP Chính (IPv4 đầu tiên)
                IPHostEntry ipEntry = Dns.GetHostEntry(hostName);
                IPAddress ipv4Address = ipEntry.AddressList
                    .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

                if (ipv4Address != null)
                {
                    lblIPValue.Text = ipv4Address.ToString();
                }
                else
                {
                    lblIPValue.Text = "Không tìm thấy IPv4";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy IP: " + ex.Message, "Lỗi Hệ Thống",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // ==========================================
            // 2. LẤY THÔNG TIN CHI TIẾT CARD MẠNG
            // ==========================================
            // Xóa các mục cũ trong ListView
            listViewAdapters.Items.Clear();

            // Lấy tất cả các Network Interface
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in adapters)
            {
                // Lọc bỏ Loopback và Card không hoạt động
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback ||
                    adapter.OperationalStatus != OperationalStatus.Up)
                {
                    continue;
                }

                // Lấy thông tin cơ bản
                string name = adapter.Description;
                string status = adapter.OperationalStatus.ToString();
                string macAddress = adapter.GetPhysicalAddress().ToString();

                // Định dạng MAC Address (Ví dụ: 00-1A-2B-3C-4D-5E)
                if (macAddress.Length > 0)
                {
                    macAddress = string.Join("-", Enumerable.Range(0, macAddress.Length / 2)
                        .Select(i => macAddress.Substring(i * 2, 2)));
                }

                // Lấy Địa chỉ IP
                string ipAddresses = "";
                IPInterfaceProperties ipProps = adapter.GetIPProperties();

                foreach (UnicastIPAddressInformation unilp in ipProps.UnicastAddresses)
                {
                    if (unilp.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipAddresses += unilp.Address.ToString() + " ";
                    }
                }

                // Thêm vào ListView
                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add(macAddress);
                item.SubItems.Add(status);
                item.SubItems.Add(string.IsNullOrWhiteSpace(ipAddresses) ? "N/A" : ipAddresses.Trim());

                listViewAdapters.Items.Add(item);
            }
        }
    }
}
