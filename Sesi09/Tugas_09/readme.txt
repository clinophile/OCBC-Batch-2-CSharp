1. Buka project menggunakan Visual Studio 2019
2. Run project :
	> klik kanan di nama project (Kantor_WEBAPI)
	> pilih menu Debug
	> pilih menu start new Instance

3. Setelah project sudah di Run, akan terbuka web browser dengan url : https://localhost:44319/swagger/index.html
4. Kemudian akan tampil Menu dengan pilihan GET, POST, GET (by ID), PUT, dan DELETE
Menu tersebut berfungsi untuk melakukan testing CRUD (create, read, update, delete) pada project

5. Menu Get All Employee
	> Pilih Menu Get /api/employee
	> Klik Try it out
	> Klik Execute
	> Program akan menampilkan seluruh Employee yang terdaftar pada database

6. Menu Get Employee By ID
	> Pilih Menu Get /api/employee/{id}
	> Klik Try it out
	> Isi id dengan angka yang diinginkan
	> Klik Execute
	> Program akan menampilkan Employee dengan id yang diinput yang terdaftar pada database
	> Jika tidak ada employee yang terdaftar dengan id yang diinput, program akan menampilkan []

7. Menu Post Employee
	> Pilih Menu Post /api/employee
	> Klik Try it out
	> Masukan data employee baru dengan format :
		{
 		 "id": 0,
  		 "nama": "string",
  		 "jenisKelamin": "string",
  		 "alamat": "string"
		}
	> Klik Execute
	> Program akan menampilkan data Employee baru yang sudah dimasukkan

7. Menu Put Employee
	> Pilih Menu Put /api/employee/{id}
	> Klik Try it out
	> Masukan data employee yang akan diupdate dengan format :
		{
 		 "id": int,
  		 "nama": "string",
  		 "jenisKelamin": "string",
  		 "alamat": "string"
		}
	> Klik Execute
	> Program akan menampilkan data Employee yang sudah diupdate

8. Menu Delete Employee
	> Pilih Menu Delete /api/employee/{id}
	> Klik Try it out
	> Isi id dengan angka yang diinginkan
	> Klik Execute
	> Program akan menampilkan "Employee Deleted" jika berhasil menghapus data employee
	> Jika tidak ada employee yang terdaftar dengan id yang diinput, program akan menampilkan "Employee with id = 5 Not Found"