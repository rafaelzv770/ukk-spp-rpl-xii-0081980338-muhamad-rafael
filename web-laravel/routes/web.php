<?php

use App\Http\Controllers\AuthController;
use Illuminate\Support\Facades\Route;
use PharIo\Manifest\AuthorCollection;

Route::get('/', function () {
    return view('form-login');
});
Route::get('form-login', [AuthController::class])->name('PRlogin');
Route::post('form-login', [AuthController::class])->name('Proseslogin');