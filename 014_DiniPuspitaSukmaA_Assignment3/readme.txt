1. Buka project menggunakan Visual Studio 2019
2. Run project :
	> klik kanan di nama project (MoviesAPI)
	> pilih menu Debug
	> pilih menu start new Instance

3. Setelah project sudah di Run, akan terbuka web browser dengan url : https://localhost:44385/swagger/index.html
4. Kemudian akan tampil Menu dengan pilihan GET, POST, GET (by ID), PUT, dan DELETE
Menu tersebut berfungsi untuk melakukan testing CRUD (create, read, update, delete) pada project

5. Menu Get All Movie
	> Pilih Menu Get /api/Movie
	> Klik Try it out
	> Klik Execute
	> Program akan menampilkan seluruh Movie yang terdaftar pada database

6. Menu Get Movie By ID
	> Pilih Menu Get /api/Movie/{id}
	> Klik Try it out
	> Isi id dengan angka yang diinginkan
	> Klik Execute
	> Program akan menampilkan Movie dengan id yang diinput yang terdaftar pada database
	> Jika tidak ada Movie yang terdaftar dengan id yang diinput, program akan menampilkan []

7. Menu Post Movie
	> Pilih Menu Post /api/Movie
	> Klik Try it out
	> Masukan data Movie baru dengan format :
		{
 		 "id": 0,
  		 "name": "string",
  		 "genre": "string",
  		 "duration": "string",
		 "releasedate" :"2020-01-01"
		}
	> Klik Execute
	> Program akan menampilkan data Movie baru yang sudah dimasukkan

7. Menu Put Movie
	> Pilih Menu Put /api/Movie/{id}
	> Klik Try it out
	> Masukan data Movie yang akan diupdate dengan format :
		{
 		 "id": 0,
  		 "name": "string",
  		 "genre": "string",
  		 "duration": "string",
		 "releasedate" :"2020-01-01"
		}
	> Klik Execute
	> Program akan menampilkan data Movie yang sudah diupdate

8. Menu Delete Movie
	> Pilih Menu Delete /api/Movie/{id}
	> Klik Try it out
	> Isi id dengan angka yang diinginkan
	> Klik Execute
	> Program akan menampilkan "Movie Deleted" jika berhasil menghapus data Movie
	> Jika tidak ada Movie yang terdaftar dengan id yang diinput, program akan menampilkan "Movie with id = 5 Not Found"