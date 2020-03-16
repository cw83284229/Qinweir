//$(function () {
//    var dataTable = $('#BooksTable').DataTable(abp.libs.datatables.normalizeConfiguration({
//        ajax: abp.libs.datatables.createAjax(qinweir.orderMaterial.materialName.getList),
//        columnDefs: [

//            //{ data: "id" },
//            //{ data: "materialsType" },
//            //{ data: "materialsName" },
//            //{ data: "units" },
//        ]
          
//    }));
//});

//var obj = document.createElement("input");
//obj.type = "text";
//document.body.appendChild(obj);

var orderStore = $("#shop").val();
var orderStore2 = document.getElementById('shop');
var orderTime = $("#time").val();
var billMaterials = $("#BooksTable").serializeArray;

var post_data = {
    "orderStore": orderStore2,
    "orderTime": orderTime,
    "remark": "",
    "billMaterials": [
        billMaterials
    ]
};

console.log(post_data);
//var pstd = $("#orderForm").formSerialize;
//console.log(pstd);

function postOrder() {
    console.log(orderStore2);
    console.log(orderTime);
    $.ajax({
        url: 'Create',
        type: 'post',
        contentType: 'application/json',
        data: JSON.stringify(post_data),
        //data: pstd,
        success: function () {
            console.log("提交成功");
        },
        error: function () {
            console.log("提交失败");
        }
    })
};