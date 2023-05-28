USE [warmPress]
GO

/****** Object:  Table [dbo].[WarmReshapeParams]    Script Date: 28-05-2023 18:29:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WarmReshapeParams](
	[BandSerial] [nvarchar](50) NOT NULL,
	[ProcessedOn] [datetime] NOT NULL,
	[LoadStartTime] [datetime] NULL,
	[PressStartTime] [datetime] NULL,
	[UnLoadStopTime] [datetime] NULL,
	[PressStopTime] [datetime] NULL,
	[TopFixtureTemp] [int] NULL,
	[BottomFixtureTemp] [int] NULL,
	[TossingItem] [nvarchar](50) NULL,
	[ZHeightCheck] [bit] NULL,
	[WarmPressCheck] [bit] NULL,
 CONSTRAINT [PK_WarmReshapeParams] PRIMARY KEY CLUSTERED 
(
	[BandSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [warmPress]
GO

/****** Object:  Table [dbo].[WarmPressTests]    Script Date: 28-05-2023 18:30:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WarmPressTests](
	[BandSerial] [nvarchar](50) NOT NULL,
	[Test] [nchar](10) NOT NULL,
	[Result] [nchar](10) NULL,
	[Units] [nchar](10) NULL,
	[Value] [nchar](10) NULL,
 CONSTRAINT [PK_WarmPressTests] PRIMARY KEY CLUSTERED 
(
	[BandSerial] ASC,
	[Test] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
