<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class siswa extends Model
{
        protected $fillable = [
        'id',
        'tahun',
        'nominal',
        'keterangan',
        'created_at',
        'updated_at'
    ];
}
