# KpopZtation_GroupB
tugas lab psd kpopztation ddd

Update Progress, yang sudah dikerjakan:
- Model
- Database query
- Factory semua tabel
- Masterpage
- UI untuk insert/update yg ada formnya, home dan cart gridview
- CRUD yg simple untuk album, artist, user

To Do yang belum dikerjakan:
- UI/Tampilan untuk view data individual
- Validasi dan CRUD (handler, controller) untuk transaction dan cart
- Session/Cookie, Roles Auth

Penjelasan layer:
- Controller: buat logic kayak validasi, session/cookie, panggil handler
- Handler: business logic kayak generate ID, panggil repository
- Repository: hubungin ke DB melalui model, CRUD, panggil model dan factory
- Factory: buat object kayak create new node di DS
