using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IP007D_SpotifyManager.Models;

public partial class SE22Context : DbContext
{
    public SE22Context()
    {
    }

    public SE22Context(DbContextOptions<SE22Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Connect> Connect { get; set; }

    public virtual DbSet<Playlist> Playlist { get; set; }

    public virtual DbSet<Song> Song { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=se22.database.windows.net;Initial Catalog=SE22;User ID=hallgato;Password=Password123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Connect>(entity =>
        {
            entity.Property(e => e.ConnectId).HasColumnName("ConnectID");
            entity.Property(e => e.PlaylistFk).HasColumnName("PlaylistFK");
            entity.Property(e => e.SongFk).HasColumnName("SongFK");

            entity.HasOne(d => d.PlaylistFkNavigation).WithMany(p => p.Connect)
                .HasForeignKey(d => d.PlaylistFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Connect_Playlist");

            entity.HasOne(d => d.SongFkNavigation).WithMany(p => p.Connect)
                .HasForeignKey(d => d.SongFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Connect_Song");
        });

        modelBuilder.Entity<Playlist>(entity =>
        {
            entity.Property(e => e.PlaylistId).HasColumnName("PlaylistID");
            entity.Property(e => e.PlaylistName).HasMaxLength(100);
        });

        modelBuilder.Entity<Song>(entity =>
        {
            entity.Property(e => e.SongId).HasColumnName("SongID");
            entity.Property(e => e.Artist).HasMaxLength(100);
            entity.Property(e => e.Bpm).HasColumnName("BPM");
            entity.Property(e => e.Genre).HasMaxLength(100);
            entity.Property(e => e.Track).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
