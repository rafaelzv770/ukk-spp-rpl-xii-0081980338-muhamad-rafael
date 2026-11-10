<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('pembayarans', function (Blueprint $table) {
            $table->id('id_pembayaran')->INT();
            $table->id('id_petugas')->INT()->NOTNULL();
            $table->string('bulan_bayar')->VARVHAR(15)->NOTNULL();
            $table->string('tahun_bayar')->VARCHAR(4)->NOTNULL();
            $table->id('id_spp')->INT()->NOTNULL();
            $table->id('jumblah_bayar')->INT()->NOTNULL();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('pembayarans');
    }
};
