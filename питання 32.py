from abc import ABC, abstractmethod

class Document(ABC):

    @abstractmethod
    def print(self):
        pass

    def prepare_for_printing(self):
        self.print()


class PDFDocument(Document):

    def print(self):
        print("Printing PDF...")


class WordDocument(Document):

    def print(self):
        print("Printing Word...")


class ExcelDocument(Document):

    def print(self):
        print("Printing Excel...")


class DocumentFactory:

    @staticmethod
    def create_document(document_type):
        if document_type == 'pdf':
            return PDFDocument()
        elif document_type == 'word':
            return WordDocument()
        elif document_type == 'excel':
            return ExcelDocument()
        else:
            raise ValueError(f"Unsupported document type: {document_type}")


if __name__ == "__main__":
    pdf_doc = DocumentFactory.create_document('pdf')
    pdf_doc.prepare_for_printing()

    word_doc = DocumentFactory.create_document('word')
    word_doc.prepare_for_printing()

    excel_doc = DocumentFactory.create_document('excel')
    excel_doc.prepare_for_printing()
