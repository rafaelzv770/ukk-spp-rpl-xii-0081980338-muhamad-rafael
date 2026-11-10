<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class kelas extends Model
{
        protected $fillable = [
        'id_kelas',
        'Nama_kelas',
        'kopetensi_keahlian',
        'created_at',
        'updated_at'
    ];
}
