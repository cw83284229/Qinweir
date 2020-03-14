$(function () {
    var dataTable = $('#BooksTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        ajax: abp.libs.datatables.createAjax(qinweir.orderMaterial.commonMaterial.getOrderList),
        columnDefs: [

            { data: "id" },
            { data: "orderStore" },
            { data: "orderTime" },
            { data: "materialsType" },
            { data: "materialsName" },
            { data: "units" },
            { data: "materiralsCount" },
            { data: "materiralsPrice" },
            { data: "remark" },

        ]
    }));
});