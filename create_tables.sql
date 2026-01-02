USE QLSach;
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DocGia]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[DocGia](
        [MaDG] [nvarchar](6) NOT NULL,
        [TenDG] [nvarchar](150) NOT NULL,
     CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED ([MaDG] ASC)
    )
    
    INSERT INTO DocGia (MaDG, TenDG) VALUES ('DG0001', N'Nguyễn Văn A');
    INSERT INTO DocGia (MaDG, TenDG) VALUES ('DG0002', N'Trần Thị B');
    INSERT INTO DocGia (MaDG, TenDG) VALUES ('DG0003', N'Lê Văn C');
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuMuon]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[PhieuMuon](
        [MaPM] [int] IDENTITY(1,1) NOT NULL,
        [MaDG] [nvarchar](6) NOT NULL,
        [MaSach] [char](6) NOT NULL, -- Matching Sach.MaSach (FixedLength, Unicode=false)
        [NgayMuon] [datetime] NOT NULL,
        [NgayTra] [datetime] NULL,
        [GhiChu] [nvarchar](250) NULL,
        [DaTra] [bit] NOT NULL DEFAULT 0,
     CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED ([MaPM] ASC)
    )

    ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_DocGia] FOREIGN KEY([MaDG])
    REFERENCES [dbo].[DocGia] ([MaDG])

    ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_Sach] FOREIGN KEY([MaSach])
    REFERENCES [dbo].[Sach] ([MaSach])
END
GO
