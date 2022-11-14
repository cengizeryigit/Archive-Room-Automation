using Arsiv_Projesi._1LoginAndAchive;
using Arsiv_Projesi.ArchiveRoom;
using Arsiv_Projesi.Section;
using Arsiv_Projesi.Shelf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_Projesi
{
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }
        int languages;

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Menus(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            Arsiv_Projesi._1LoginAndAchive.ArchiveLoad loadarchive = new _1LoginAndAchive.ArchiveLoad();
            Menus(loadarchive);
        }

        private void ToolStripMenuItemListArchiveRoom_Click(object sender, EventArgs e)
        {
            ArchiveRoom.ListArchiveRoom listarchiveroom = new ArchiveRoom.ListArchiveRoom();
            if (languages == 1)
            {
                listarchiveroom.ListArchiveRoomButton.Text = "ARŞİV ODASI LİSTELE";
            }
            else
            {
                listarchiveroom.ListArchiveRoomButton.Text = "LIST ARCHIVE ROOM";
            }
            
            Menus(listarchiveroom);
        }

        private void ToolStripMenuItemSearchArchiveRoom_Click(object sender, EventArgs e)
        {
            ArchiveRoom.SearchArchiveRoom searcharchiveroom = new ArchiveRoom.SearchArchiveRoom();
            if (languages == 1)
            {
                searcharchiveroom.SearchArchiveRoomButton.Text = "ARŞİV ODASI ARA";
            }
            else
            {
                searcharchiveroom.SearchArchiveRoomButton.Text = "SEARCH ARCHIVE ROOM";
            }

            Menus(searcharchiveroom);
        }

        private void ToolStripMenuItemAddArchiveRoom_Click(object sender, EventArgs e)
        {
            ArchiveRoom.AddArchiveRoom addarchiveroom = new ArchiveRoom.AddArchiveRoom();
            if (languages == 1)
            {
                addarchiveroom.AddArchiveRoomButton.Text = "ARŞİV ODASI EKLE";
            }
            else
            {
                addarchiveroom.AddArchiveRoomButton.Text = "ADD ARCHIVE ROOM";
            }
            Menus(addarchiveroom);
        }

        private void ToolStripMenuItemUpdateArchiveRoom_Click(object sender, EventArgs e)
        {
            ArchiveRoom.UpdateArchiveRoom updatearchiveroom = new ArchiveRoom.UpdateArchiveRoom();
            if (languages == 1)
            {
                updatearchiveroom.UpdateArchiveRoomButton.Text = "ARŞİV ODASI GÜNCELLE";
            }
            else
            {
                updatearchiveroom.UpdateArchiveRoomButton.Text = "UPDATE ARCHIVE ROOM";
            }
            Menus(updatearchiveroom);
        }

        private void ToolStripMenuItemDeleteArchiveRoom_Click(object sender, EventArgs e)
        {
            ArchiveRoom.DeleteArchiveRoom deletearchiveroom = new ArchiveRoom.DeleteArchiveRoom();
            if (languages == 1)
            {
                deletearchiveroom.DeleteArchiveRoomButton.Text = "ARŞİV ODASI SİL";
            }
            else
            {
                deletearchiveroom.DeleteArchiveRoomButton.Text = "DELETE ARCHIVE ROOM";
            }
            Menus(deletearchiveroom);
        }

        private void ToolStripMenuItemListSection_Click(object sender, EventArgs e)
        {
            Section.ListSection listsection = new Section.ListSection();
            if (languages == 1)
            {
                listsection.ListSectionButton.Text = "BÖLÜM LİSTELE";
            }
            else
            {
                listsection.ListSectionButton.Text = "LIST SECTION";
            }
            Menus(listsection);
        }

        private void ToolStripMenuItemSearchSection_Click(object sender, EventArgs e)
        {
            Section.SearchSectioncs searchsection = new Section.SearchSectioncs();
            if (languages == 1)
            {
                searchsection.SearchSectionButton.Text = "BÖLÜM ARA";
            }
            else
            {
                searchsection.SearchSectionButton.Text = "SEARCH SECTION";
            }
            Menus(searchsection);
        }

        private void ToolStripMenuItemAddSection_Click(object sender, EventArgs e)
        {
            Section.AddSection addsection = new Section.AddSection();
            if (languages == 1)
            {
                addsection.AddSectionButton.Text = "BÖLÜM EKLE";
            }
            else
            {
                addsection.AddSectionButton.Text = "ADD SECTION";
            }
            Menus(addsection);
        }

        private void ToolStripMenuItemUpdateSection_Click(object sender, EventArgs e)
        {
            Section.UpdateSection updatesection = new Section.UpdateSection();
            if (languages == 1)
            {
                updatesection.UpdateSectionButton.Text = "BÖLÜM GÜNCELLE";
            }
            else
            {
                updatesection.UpdateSectionButton.Text = "UPDATE SECTION";
            }
            Menus(updatesection);
        }

        private void ToolStripMenuItemDeleteSection_Click(object sender, EventArgs e)
        {
            Section.DeleteSection deletesection = new Section.DeleteSection();
            if (languages == 1)
            {
                deletesection.DeleteSectionButton.Text = "BÖLÜM SİL";
            }
            else
            {
                deletesection.DeleteSectionButton.Text = "DELETE SECTION";
            }
            Menus(deletesection);
        }

        private void ToolStripMenuItemListShelf_Click(object sender, EventArgs e)
        {
            Shelf.ListShelf listshelf = new Shelf.ListShelf();
            if (languages == 1)
            {
                listshelf.ListShelfButton.Text = "RAF LİSTELE";
            }
            else
            {
                listshelf.ListShelfButton.Text = "LIST SHELF";
            }
            Menus(listshelf);
        }

        private void ToolStripMenuItemSearchShelf_Click(object sender, EventArgs e)
        {
            Shelf.SearchShelf searchshelf = new Shelf.SearchShelf();
            if (languages == 1)
            {
                searchshelf.SearchShelfButton.Text = "RAF ARA";
            }
            else
            {
                searchshelf.SearchShelfButton.Text = "SEARCH SHELF";
            }
            searchshelf.MdiParent = this;
            searchshelf.Show();
        }

        private void ToolStripMenuItemAddShelf_Click(object sender, EventArgs e)
        {
            Shelf.AddShelf addshelf = new Shelf.AddShelf();
            if (languages == 1)
            {
                addshelf.AddShelfButton.Text = "RAF EKLE";
            }
            else
            {
                addshelf.AddShelfButton.Text = "ADD SHELF";
            }
            addshelf.MdiParent = this;
            addshelf.Show();
        }

        private void ToolStripMenuItemUpdateShelf_Click(object sender, EventArgs e)
        {
            Shelf.UpdateShelf updateshelf = new Shelf.UpdateShelf();
            if (languages == 1)
            {
                updateshelf.UpdateShelfButton.Text = "RAF GÜNCELLE";
            }
            else
            {
                updateshelf.UpdateShelfButton.Text = "UPDATE SHELF";
            }
            updateshelf.MdiParent = this;
            updateshelf.Show();
        }

        private void ToolStripMenuItemDeleteShelf_Click(object sender, EventArgs e)
        {
            Shelf.DeleteShelf deleteshelf = new Shelf.DeleteShelf();
            if (languages == 1)
            {
                deleteshelf.DeleteShelfButton.Text = "RAF SİL";
            }
            else
            {
                deleteshelf.DeleteShelfButton.Text = "DELETE SHELF";
            }
            deleteshelf.MdiParent = this;
            deleteshelf.Show();
        }

        private void ToolStripMenuItemListFolder_Click(object sender, EventArgs e)
        {
            _5Folder.ListFolder listfolder = new _5Folder.ListFolder();
            if (languages == 1)
            {
                listfolder.ListFolderButton.Text = "KLASÖR LİSTELE";
            }
            else
            {
                listfolder.ListFolderButton.Text = "LIST FOLDER";
            }
            listfolder.MdiParent = this;
            listfolder.Show();
        }

        private void ToolStripMenuItemSearchFolder_Click(object sender, EventArgs e)
        {
            _5Folder.SearchFolder searchfolder = new _5Folder.SearchFolder();
            if (languages == 1)
            {
                searchfolder.SearchFolderButton.Text = "KLASÖR ARA";
            }
            else
            {
                searchfolder.SearchFolderButton.Text = "SEARCH FOLDER";
            }
            searchfolder.MdiParent = this;
            searchfolder.Show();
        }

        private void ToolStripMenuItemAddFolder_Click(object sender, EventArgs e)
        {
            _5Folder.AddFolder addfolder = new _5Folder.AddFolder();
            if (languages == 1)
            {
                addfolder.AddFolderButton.Text = "KLASÖR EKLE";
            }
            else
            {
                addfolder.AddFolderButton.Text = "ADD FOLDER";
            }
            addfolder.MdiParent = this;
            addfolder.Show();
        }

        private void ToolStripMenuItemUpdateFolder_Click(object sender, EventArgs e)
        {
            _5Folder.UpdateFolder updatefolder = new _5Folder.UpdateFolder();
            if (languages == 1)
            {
                updatefolder.UpdateFolderButton.Text = "KLASÖR GÜNCELLE";
            }
            else
            {
                updatefolder.UpdateFolderButton.Text = "UPDATE FOLDER";
            }
            updatefolder.MdiParent = this;
            updatefolder.Show();
        }

        private void ToolStripMenuItemDeleteFolder_Click(object sender, EventArgs e)
        {
            _5Folder.DeleteFolder deletefolder = new _5Folder.DeleteFolder();
            if (languages == 1)
            {
                deletefolder.DeleteFolderButton.Text = "KLASÖR SİL";
            }
            else
            {
                deletefolder.DeleteFolderButton.Text = "DELETE FOLDER";
            }
            deletefolder.MdiParent = this;
            deletefolder.Show();
        }

        private void ToolStripMenuItemListFile_Click(object sender, EventArgs e)
        {
            _6File.ListFile listfile = new _6File.ListFile();
            if (languages == 1)
            {
                listfile.ListFileButton.Text = "DOSYA LİSTELE";
            }
            else
            {
                listfile.ListFileButton.Text = "LIST FILE";
            }
            listfile.MdiParent = this;
            listfile.Show();
        }

        private void ToolStripMenuItemSearchFile_Click(object sender, EventArgs e)
        {
            _6File.SearchFile searchfile = new _6File.SearchFile();
            if (languages == 1)
            {
                searchfile.SearchFileButton.Text = "DOSYA ARA";
            }
            else
            {
                searchfile.SearchFileButton.Text = "SEARCH FILE";
            }
            searchfile.MdiParent= this;
            searchfile.Show();
        }

        private void ToolStripMenuItemAddFile_Click(object sender, EventArgs e)
        {
            _6File.AddFile addfile = new _6File.AddFile();
            if (languages == 1)
            {
                addfile.AddFileButton.Text = "DOSYA EKLE";
            }
            else
            {
                addfile.AddFileButton.Text = "ADD FILE";
            }
            addfile.MdiParent = this;
            addfile.Show();
        }

        private void ToolStripMenuItemUpdateFile_Click(object sender, EventArgs e)
        {
            _6File.UpdateFile updatefile = new _6File.UpdateFile();
            if (languages == 1)
            {
                updatefile.UpdateFileButton.Text = "DOSYA GÜNCELLE";
            }
            else
            {
                updatefile.UpdateFileButton.Text = "UPDATE FILE";
            }
            updatefile.MdiParent = this;
            updatefile.Show();
        }

        private void ToolStripMenuItemDeleteFile_Click(object sender, EventArgs e)
        {
            _6File.DeleteFile deletefile = new _6File.DeleteFile();
            if (languages == 1)
            {
                deletefile.DeleteFileButton.Text = "DOSYA SİL";
            }
            else
            {
                deletefile.DeleteFileButton.Text = "DELETE FILE";
            }
            deletefile.MdiParent = this;
            deletefile.Show();
        }

        private void ToolStripMenuItemListDocument_Click(object sender, EventArgs e)
        {
            _7Document.ListDocument listdocument = new _7Document.ListDocument();
            if (languages == 1)
            {
                listdocument.ListDocumentButton.Text = "EVRAK LİSTELE";
            }
            else
            {
                listdocument.ListDocumentButton.Text = "LIST DOCUMENT";
            }
            listdocument.MdiParent = this;
            listdocument.Show();

        }

        private void ToolStripMenuItemSearchDocument_Click(object sender, EventArgs e)
        {
            _7Document.SearchDocument searchdocument = new _7Document.SearchDocument();
            if (languages == 1)
            {
                searchdocument.SearchDocumentButton.Text = "EVRAK ARA";
            }
            else
            {
                searchdocument.SearchDocumentButton.Text = "SEARCH DOCUMENT";
            }
            searchdocument.MdiParent = this;
            searchdocument.Show();
        }

        private void ToolStripMenuItemAddDocument_Click(object sender, EventArgs e)
        {
            _7Document.AddDocument adddocument = new _7Document.AddDocument();
            if (languages == 1)
            {
                adddocument.AddDocumentButton.Text = "EVRAK EKLE";
            }
            else
            {
                adddocument.AddDocumentButton.Text = "ADD DOCUMENT";
            }
            adddocument.MdiParent = this;
            adddocument.Show();
        }

        private void ToolStripMenuItemUpdateDocument_Click(object sender, EventArgs e)
        {
            _7Document.UpdateDocument updatedocument = new _7Document.UpdateDocument();
            if (languages == 1)
            {
                updatedocument.UpdateDocumentButton.Text = "EVRAK GÜNCELLE";
            }
            else
            {
                updatedocument.UpdateDocumentButton.Text = "DELETE DOCUMENT";
            }
            updatedocument.MdiParent = this;
            updatedocument.Show();
        }

        private void ToolStripMenuItemDeleteDocument_Click(object sender, EventArgs e)
        {
            _7Document.DeleteDocument deletedocument = new _7Document.DeleteDocument();
            if (languages == 1)
            {
                deletedocument.DeleteDocumentButton.Text = "EVRAK SİL";
            }
            else
            {
                deletedocument.DeleteDocumentButton.Text = "DELETE DOCUMENT";
            }
            deletedocument.MdiParent = this;
            deletedocument.Show();
        }
        
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            languages = 0;
            _1LoginAndAchive.ArchiveLoad archiveLoad = new _1LoginAndAchive.ArchiveLoad();
            archiveLoad.Welcome.Text = "WELCOME";
           

            ToolStripMenuItemArchiveRoom.Text = "Archive Room";
            ToolStripMenuItemListArchiveRoom.Text = "List Archive Room";
            ToolStripMenuItemSearchArchiveRoom.Text = "Search Archive Room";
            ToolStripMenuItemAddArchiveRoom.Text = "Add Archive Room";
            ToolStripMenuItemUpdateArchiveRoom.Text = "Update Archive Room";
            ToolStripMenuItemDeleteArchiveRoom.Text = "Delete Archive Room";

            ToolStripMenuItemSection.Text = "Section";
            ToolStripMenuItemListSection.Text = "List Section";
            ToolStripMenuItemSearchSection.Text = "Search Section";
            ToolStripMenuItemAddSection.Text = "Add Section";
            ToolStripMenuItemUpdateSection.Text = "Update Section";
            ToolStripMenuItemDeleteSection.Text = "Delete Section";

            ToolStripMenuItemShelf.Text = "Shelf";
            ToolStripMenuItemListShelf.Text = "List Shelf";
            ToolStripMenuItemSearchShelf.Text = "Search Shelf";
            ToolStripMenuItemAddShelf.Text = "Add Shelf";
            ToolStripMenuItemUpdateShelf.Text = "Update Shelf";
            ToolStripMenuItemDeleteShelf.Text = "Delete Shelf";

            ToolStripMenuItemFolder.Text = "Folder";
            ToolStripMenuItemListFolder.Text = "List Folder";
            ToolStripMenuItemSearchFolder.Text = "Search Folder";
            ToolStripMenuItemAddFolder.Text = "Add Folder";
            ToolStripMenuItemUpdateFolder.Text = "Update Folder";
            ToolStripMenuItemDeleteFolder.Text = "Delete Folder";

            ToolStripMenuItemFile.Text = "File";
            ToolStripMenuItemListFile.Text = "List File";
            ToolStripMenuItemSearchFile.Text = "Search File";
            ToolStripMenuItemAddFile.Text = "Add File";
            ToolStripMenuItemUpdateFile.Text = "Update File";
            ToolStripMenuItemDeleteFile.Text = "Delete File";

            ToolStripMenuItemDocument.Text = "Document";
            ToolStripMenuItemListDocument.Text = "List Document";
            ToolStripMenuItemSearchDocument.Text = "Search Document";
            ToolStripMenuItemAddDocument.Text = "Add Document";
            ToolStripMenuItemUpdateDocument.Text = "Update Document";
            ToolStripMenuItemDeleteDocument.Text = "Delete Document";

            Language.Text = "Language";
            englishToolStripMenuItem.Text = "English";
            turkishToolStripMenuItem.Text = "Turkish";

            ExitApplication.Text = "Exit";


            ArchiveRoom.AddArchiveRoom addArchiveRoom = new ArchiveRoom.AddArchiveRoom();
            addArchiveRoom.AddArchiveRoomButton.Text = "ADD ARCHIVE ROOM";
            ArchiveRoom.DeleteArchiveRoom deleteArchiveRoom = new ArchiveRoom.DeleteArchiveRoom();
            deleteArchiveRoom.DeleteArchiveRoomButton.Text = "DELETE ARCHIVE ROOM";
            ArchiveRoom.ListArchiveRoom listArchiveRoom = new ArchiveRoom.ListArchiveRoom();
            listArchiveRoom.ListArchiveRoomButton.Text = "LIST ARCHIVE ROOM";
            ArchiveRoom.SearchArchiveRoom searchArchiveRoom = new ArchiveRoom.SearchArchiveRoom();
            searchArchiveRoom.SearchArchiveRoomButton.Text = "SEARCH ARCHIVE ROOM";
            ArchiveRoom.UpdateArchiveRoom updateArchiveRoom = new ArchiveRoom.UpdateArchiveRoom();
            updateArchiveRoom.UpdateArchiveRoomButton.Text = "UPDATE ARCHIVE ROOM";


            Section.AddSection addSection = new Section.AddSection();
            addSection.AddSectionButton.Text = "ADD SECTION";
            Section.DeleteSection deleteSection = new Section.DeleteSection();
            deleteSection.DeleteSectionButton.Text = "DELETE SECTION";
            Section.ListSection listSection = new Section.ListSection();
            listSection.ListSectionButton.Text = "LIST SECTION";
            Section.SearchSectioncs searchSectioncs = new Section.SearchSectioncs();
            searchSectioncs.SearchSectionButton.Text = "SEARCH SECTION";
            Section.UpdateSection updateSection = new Section.UpdateSection();
            updateSection.UpdateSectionButton.Text = "UPDATE SECTION";


            Shelf.AddShelf addShelf = new Shelf.AddShelf();
            addShelf.AddShelfButton.Text = "ADD SHELF";
            Shelf.DeleteShelf deleteShelf = new Shelf.DeleteShelf();
            deleteShelf.DeleteShelfButton.Text = "DELETE SHELF";
            Shelf.ListShelf listShelf = new Shelf.ListShelf();
            listShelf.ListShelfButton.Text = "LIST SHELF";
            Shelf.SearchShelf searchShelf = new Shelf.SearchShelf();
            searchShelf.SearchShelfButton.Text = "SEARCH SHELF";
            Shelf.UpdateShelf updateShelf = new Shelf.UpdateShelf();
            updateShelf.UpdateShelfButton.Text = "UPDATE SHELF";


            _5Folder.AddFolder addFolder = new _5Folder.AddFolder();
            addFolder.AddFolderButton.Text = "ADD FOLDER";
            _5Folder.DeleteFolder deleteFolder = new _5Folder.DeleteFolder();
            deleteFolder.DeleteFolderButton.Text = "DELETE FOLDER";
            _5Folder.ListFolder listFolder = new _5Folder.ListFolder();
            listFolder.ListFolderButton.Text = "LIST FOLDER";
            _5Folder.SearchFolder searchFolder = new _5Folder.SearchFolder();
            searchFolder.SearchFolderButton.Text = "SEARCH FOLDER";
            _5Folder.UpdateFolder updateFolder = new _5Folder.UpdateFolder();
            updateFolder.UpdateFolderButton.Text = "UPDATE FOLDER";


            _6File.AddFile addFile = new _6File.AddFile();
            addFile.AddFileButton.Text = "ADD FILE";
            _6File.DeleteFile deleteFile = new _6File.DeleteFile();
            deleteFile.DeleteFileButton.Text = "DELETE FILE";
            _6File.ListFile listFile = new _6File.ListFile();
            listFile.ListFileButton.Text = "LIST FILE";
            _6File.SearchFile searchFile = new _6File.SearchFile();
            searchFile.SearchFileButton.Text = "SEARCH FILE";
            _6File.UpdateFile updateFile = new _6File.UpdateFile();
            updateFile.UpdateFileButton.Text = "UPDATE FILE";

            _7Document.AddDocument addDocument = new _7Document.AddDocument();
            addDocument.AddDocumentButton.Text = "ADD DOCUMENT";
            _7Document.DeleteDocument deleteDocument = new _7Document.DeleteDocument();
            deleteDocument.DeleteDocumentButton.Text = "DELETE DOCUMENT";
            _7Document.ListDocument listDocument = new _7Document.ListDocument();
            listDocument.ListDocumentButton.Text = "LIST DOCUMENT";
            _7Document.SearchDocument searchDocument = new _7Document.SearchDocument();
            searchDocument.SearchDocumentButton.Text = "SEARCH DOCUMENT";
            _7Document.UpdateDocument updateDocument = new _7Document.UpdateDocument();
            updateDocument.UpdateDocumentButton.Text = "UPDATE DOCUMENT";
            Menus(archiveLoad);

        }

        public void turkishToolStripMenuItem_Click(object sender, EventArgs e)
        {

            languages = 1;
            _1LoginAndAchive.ArchiveLoad archiveLoad = new _1LoginAndAchive.ArchiveLoad();
            archiveLoad.Welcome.Text = "HOŞGELDİNİZ";

            ToolStripMenuItemArchiveRoom.Text = "Arşiv Odası";
            ToolStripMenuItemListArchiveRoom.Text = "Arşiv Odası Listele";
            ToolStripMenuItemSearchArchiveRoom.Text = "Arşiv Odası Ara";
            ToolStripMenuItemAddArchiveRoom.Text = "Arşiv Odası Ekle";
            ToolStripMenuItemUpdateArchiveRoom.Text = "Arşiv Odası Güncelle";
            ToolStripMenuItemDeleteArchiveRoom.Text = "Arşiv Odası Sil";

            ToolStripMenuItemSection.Text = "Bölüm";
            ToolStripMenuItemListSection.Text = "Bölüm Listele";
            ToolStripMenuItemSearchSection.Text = "Bölüm Ara";
            ToolStripMenuItemAddSection.Text = "Bölüm Ekle";
            ToolStripMenuItemUpdateSection.Text = "Bölüm Güncelle";
            ToolStripMenuItemDeleteSection.Text = "Bölüm Sil";

            ToolStripMenuItemShelf.Text = "Raf";
            ToolStripMenuItemListShelf.Text = "Raf Listele";
            ToolStripMenuItemSearchShelf.Text = "Raf Ara";
            ToolStripMenuItemAddShelf.Text = "Raf Ekle";
            ToolStripMenuItemUpdateShelf.Text = "Raf Güncelle";
            ToolStripMenuItemDeleteShelf.Text = "Raf Sil";

            ToolStripMenuItemFolder.Text = "Klasör";
            ToolStripMenuItemListFolder.Text = "Klasör Listele";
            ToolStripMenuItemSearchFolder.Text = "Klasör Ara";
            ToolStripMenuItemAddFolder.Text = "Klasör Ekle";
            ToolStripMenuItemUpdateFolder.Text = "Klasör Güncelle";
            ToolStripMenuItemDeleteFolder.Text = "Klasör Sil";

            ToolStripMenuItemFile.Text = "Dosya";
            ToolStripMenuItemListFile.Text = "Dosya Listele";
            ToolStripMenuItemSearchFile.Text = "Dosya Ara";
            ToolStripMenuItemAddFile.Text = "Dosya Ekle";
            ToolStripMenuItemUpdateFile.Text = "Dosya Güncelle";
            ToolStripMenuItemDeleteFile.Text = "Dosya Sil";

            ToolStripMenuItemDocument.Text = "Evrak";
            ToolStripMenuItemListDocument.Text = "Evrak Listele";
            ToolStripMenuItemSearchDocument.Text = "Evrak Ara";
            ToolStripMenuItemAddDocument.Text = "Evrak Ekle";
            ToolStripMenuItemUpdateDocument.Text = "Evrak Güncelle";
            ToolStripMenuItemDeleteDocument.Text = "Evrak Sil";

            Language.Text = "Dil";
            englishToolStripMenuItem.Text = "İngilizce";
            turkishToolStripMenuItem.Text = "Türkçe";

            ExitApplication.Text = "Çıkış";



            ArchiveRoom.AddArchiveRoom addArchiveRoom = new ArchiveRoom.AddArchiveRoom();
            addArchiveRoom.AddArchiveRoomButton.Text = "ARŞİV ODASI EKLE";
            ArchiveRoom.DeleteArchiveRoom deleteArchiveRoom = new ArchiveRoom.DeleteArchiveRoom();
            deleteArchiveRoom.DeleteArchiveRoomButton.Text = "ARŞİV ODASI SİL";
            ArchiveRoom.ListArchiveRoom listArchiveRoom = new ArchiveRoom.ListArchiveRoom();
            listArchiveRoom.ListArchiveRoomButton.Text = "ARŞİV ODASI LİSTELE";
            ArchiveRoom.SearchArchiveRoom searchArchiveRoom = new ArchiveRoom.SearchArchiveRoom();
            searchArchiveRoom.SearchArchiveRoomButton.Text = "ARŞİV ODASI ARA";
            ArchiveRoom.UpdateArchiveRoom updateArchiveRoom = new ArchiveRoom.UpdateArchiveRoom();
            updateArchiveRoom.UpdateArchiveRoomButton.Text = "ARŞİV ODASI GÜNCELLE";


            Section.AddSection addSection = new Section.AddSection();
            addSection.AddSectionButton.Text = "BÖLÜM EKLE";
            Section.DeleteSection deleteSection = new Section.DeleteSection();
            deleteSection.DeleteSectionButton.Text = "BÖLÜM SİL";
            Section.ListSection listSection = new Section.ListSection();
            listSection.ListSectionButton.Text = "BÖLÜM LİSTELE";
            Section.SearchSectioncs searchSectioncs = new Section.SearchSectioncs();
            searchSectioncs.SearchSectionButton.Text = "BÖLÜM ARA";
            Section.UpdateSection updateSection = new Section.UpdateSection();
            updateSection.UpdateSectionButton.Text = "BÖLÜM GÜNCELLE";


            Shelf.AddShelf addShelf = new Shelf.AddShelf();
            addShelf.AddShelfButton.Text = "RAF EKLE";
            Shelf.DeleteShelf deleteShelf = new Shelf.DeleteShelf();
            deleteShelf.DeleteShelfButton.Text = "RAF SİL";
            Shelf.ListShelf listShelf = new Shelf.ListShelf();
            listShelf.ListShelfButton.Text = "RAF LİSTELE";
            Shelf.SearchShelf searchShelf = new Shelf.SearchShelf();
            searchShelf.SearchShelfButton.Text = "RAF ARA";
            Shelf.UpdateShelf updateShelf = new Shelf.UpdateShelf();
            updateShelf.UpdateShelfButton.Text = "RAF GÜNCELLE";


            _5Folder.AddFolder addFolder = new _5Folder.AddFolder();
            addFolder.AddFolderButton.Text = "KLASÖR EKLE";
            _5Folder.DeleteFolder deleteFolder = new _5Folder.DeleteFolder();
            deleteFolder.DeleteFolderButton.Text = "KLASÖR SİL";
            _5Folder.ListFolder listFolder = new _5Folder.ListFolder();
            listFolder.ListFolderButton.Text = "KLASÖR LİSTELE";
            _5Folder.SearchFolder searchFolder = new _5Folder.SearchFolder();
            searchFolder.SearchFolderButton.Text = "KLASÖR ARA";
            _5Folder.UpdateFolder updateFolder = new _5Folder.UpdateFolder();
            updateFolder.UpdateFolderButton.Text = "KLASÖR GÜNCELLE";


            _6File.AddFile addFile = new _6File.AddFile();
            addFile.AddFileButton.Text = "DOSYA EKLE";
            _6File.DeleteFile deleteFile = new _6File.DeleteFile();
            deleteFile.DeleteFileButton.Text = "DOSYA SİL";
            _6File.ListFile listFile = new _6File.ListFile();
            listFile.ListFileButton.Text = "DOSYA LİSTELE";
            _6File.SearchFile searchFile = new _6File.SearchFile();
            searchFile.SearchFileButton.Text = "DOSYA ARA";
            _6File.UpdateFile updateFile = new _6File.UpdateFile();
            updateFile.UpdateFileButton.Text = "DOOSYA GÜNCELLE";

            _7Document.AddDocument addDocument = new _7Document.AddDocument();
            addDocument.AddDocumentButton.Text = "EVRAK EKLE";
            _7Document.DeleteDocument deleteDocument = new _7Document.DeleteDocument();
            deleteDocument.DeleteDocumentButton.Text = "EVRAK SİL";
            _7Document.ListDocument listDocument = new _7Document.ListDocument();
            listDocument.ListDocumentButton.Text = "EVRAK LİSTELE";
            _7Document.SearchDocument searchDocument = new _7Document.SearchDocument();
            searchDocument.SearchDocumentButton.Text = "EVRAK ARA";
            _7Document.UpdateDocument updateDocument = new _7Document.UpdateDocument();
            updateDocument.UpdateDocumentButton.Text = "EVRAK GÜNCELLE";

            Menus(archiveLoad);

            
        }
    }
}
