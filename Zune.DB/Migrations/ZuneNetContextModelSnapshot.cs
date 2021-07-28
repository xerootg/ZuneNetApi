﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zune.DB;

namespace Zune.DB.Migrations
{
    [DbContext(typeof(ZuneNetContext))]
    partial class ZuneNetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Atom.Xml.Link", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Href")
                        .HasColumnType("TEXT");

                    b.Property<string>("MemberId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Relation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("Zune.DB.Models.Badge", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MediaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("MediaType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("AvailableBadges");
                });

            modelBuilder.Entity("Zune.DB.Models.Comment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Zune.DB.Models.Joining.MemberBadge", b =>
                {
                    b.Property<string>("MemberId")
                        .HasColumnType("TEXT");

                    b.Property<string>("BadgeId")
                        .HasColumnType("TEXT");

                    b.HasKey("MemberId", "BadgeId");

                    b.ToTable("MemberBadge");
                });

            modelBuilder.Entity("Zune.DB.Models.Joining.MemberMember", b =>
                {
                    b.Property<string>("MemberAId")
                        .HasColumnType("TEXT");

                    b.Property<string>("MemberBId")
                        .HasColumnType("TEXT");

                    b.HasKey("MemberAId", "MemberBId");

                    b.HasIndex("MemberBId");

                    b.ToTable("MemberMember");
                });

            modelBuilder.Entity("Zune.DB.Models.Member", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AcceptedTermsOfService")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AccountSuspended")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Background")
                        .HasColumnType("TEXT");

                    b.Property<string>("BillingInstanceId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("BillingUnavailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ExplicitPrivilege")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastLabelTakedownDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Lightweight")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Locale")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("MediaTypeTunerRegisterInfoId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ParentallyControlled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayCount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PointsBalance")
                        .HasColumnType("REAL");

                    b.Property<double>("SongCreditBalance")
                        .HasColumnType("REAL");

                    b.Property<string>("SongCreditRenewalDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SubscriptionBillingViolation")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SubscriptionEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubscriptionEndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SubscriptionLapsed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubscriptionMeteringCertificate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubscriptionOfferId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SubscriptionPendingCancel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubscriptionRenewalOfferId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubscriptionStartDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TagChangeRequired")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.Property<bool>("UsageCollectionAllowed")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserReadID")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserTile")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserWriteID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Xuid")
                        .HasColumnType("TEXT");

                    b.Property<string>("ZuneTag")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MediaTypeTunerRegisterInfoId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Zune.DB.Models.Message", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AlbumTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("AltLinkId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArtistName")
                        .HasColumnType("TEXT");

                    b.Property<string>("DetailsLink")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MediaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaylistName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PodcastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PodcastUrl")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Received")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReplyLinkId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SongTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.Property<string>("TextContent")
                        .HasColumnType("TEXT");

                    b.Property<int>("TrackNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Wishlist")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AltLinkId");

                    b.HasIndex("ReplyLinkId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Zune.DB.Models.Tuner", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tuners");
                });

            modelBuilder.Entity("Atom.Xml.Link", b =>
                {
                    b.HasOne("Zune.DB.Models.Member", null)
                        .WithMany("Playlists")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("Zune.DB.Models.Comment", b =>
                {
                    b.HasOne("Zune.DB.Models.Member", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Zune.DB.Models.Member", "Recipient")
                        .WithMany("Comments")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Recipient");
                });

            modelBuilder.Entity("Zune.DB.Models.Joining.MemberBadge", b =>
                {
                    b.HasOne("Zune.DB.Models.Badge", "Badge")
                        .WithMany("Members")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zune.DB.Models.Member", "Member")
                        .WithMany("Badges")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Badge");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Zune.DB.Models.Joining.MemberMember", b =>
                {
                    b.HasOne("Zune.DB.Models.Member", "MemberA")
                        .WithMany("Friends")
                        .HasForeignKey("MemberAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zune.DB.Models.Member", "MemberB")
                        .WithMany()
                        .HasForeignKey("MemberBId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MemberA");

                    b.Navigation("MemberB");
                });

            modelBuilder.Entity("Zune.DB.Models.Member", b =>
                {
                    b.HasOne("Zune.DB.Models.Tuner", "MediaTypeTunerRegisterInfo")
                        .WithMany()
                        .HasForeignKey("MediaTypeTunerRegisterInfoId");

                    b.Navigation("MediaTypeTunerRegisterInfo");
                });

            modelBuilder.Entity("Zune.DB.Models.Message", b =>
                {
                    b.HasOne("Atom.Xml.Link", "AltLink")
                        .WithMany()
                        .HasForeignKey("AltLinkId");

                    b.HasOne("Zune.DB.Models.Member", "Recipient")
                        .WithMany("Messages")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Atom.Xml.Link", "ReplyLink")
                        .WithMany()
                        .HasForeignKey("ReplyLinkId");

                    b.HasOne("Zune.DB.Models.Member", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");

                    b.Navigation("AltLink");

                    b.Navigation("Recipient");

                    b.Navigation("ReplyLink");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Zune.DB.Models.Tuner", b =>
                {
                    b.HasOne("Zune.DB.Models.Member", "Member")
                        .WithOne("TunerRegisterInfo")
                        .HasForeignKey("Zune.DB.Models.Tuner", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Zune.DB.Models.Badge", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("Zune.DB.Models.Member", b =>
                {
                    b.Navigation("Badges");

                    b.Navigation("Comments");

                    b.Navigation("Friends");

                    b.Navigation("Messages");

                    b.Navigation("Playlists");

                    b.Navigation("TunerRegisterInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
